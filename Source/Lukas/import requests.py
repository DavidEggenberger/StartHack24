import base64
import json
import os
import pickle
from datetime import datetime
from email.mime.text import MIMEText
from email.mime.multipart import MIMEMultipart
from google_auth_oauthlib.flow import InstalledAppFlow
from google.auth.transport.requests import Request
from googleapiclient.discovery import build
from googleapiclient.errors import HttpError
import openai

SCOPES = ['https://www.googleapis.com/auth/gmail.modify']
promptinstructions = """
You have received multiple emails from Fellowship Alumni. Please summarize the content using, where important, bullet points. 
Please emphazise importent startup highlights such as funding rounds, product launches, and other milestones. 
Also separately mention any significant ESG contributions. The summary will be sent to investors and other stakeholders looking 
for a quick overview of the latest developments. Thus, please focus on the most important information. If one of the startups does
not have any significant updates, please do not include it in the summary. Keep the summary to a maximum of 150 words. Keep the summary short and to the point.
Please make sure to include the sender's name in the summary. It is possible that you only received one email. Never come up with
your own data. Only summarize what you find in the provided emails. Wrong information will be punished. Thank you!
"""

list_of_recipients = ["lukas.eggenberger54@gmail.com", "nora.suter@besonet.ch"]

def load_api_key(config_path):
    try:
        with open(config_path, 'r') as config_file:
            config = json.load(config_file)
            return config.get("openai_api_key")
    except Exception as e:
        print(f"Error loading the API key: {e}")
        return None

openai.api_key = load_api_key("C:\\Users\\lukas\\OneDrive\\Desktop\\StartHack24\\openaikey.json")

def extract_email_address(sender_info):
    if "<" in sender_info:
        start = sender_info.find("<") + 1
        end = sender_info.find(">", start)
        return sender_info[start:end]
    return sender_info

def get_email_details_and_mark_as_read(service, user_id, msg_id):
    try:
        message = service.users().messages().get(userId=user_id, id=msg_id, format='full').execute()
        headers = message['payload']['headers']
        sender = subject = body = date = ""
        
        for header in headers:
            if header['name'].lower() == 'from':
                sender = header['value']
            elif header['name'].lower() == 'subject':
                subject = header['value']
            elif header['name'].lower() == 'date':
                date = header['value']

        part = message['payload']
        if 'parts' in part:
            part_body = part['parts'][0]['body']
            body_data = part_body.get('data', part['body'].get('data'))
        else:
            body_data = part['body']['data']

        body = base64.urlsafe_b64decode(body_data).decode('UTF-8')
        sender_email = extract_email_address(sender)
        sender_name = sender.split(" ")[0] if sender_email != sender else ""

        service.users().messages().modify(userId=user_id, id=msg_id, body={'removeLabelIds': ['UNREAD']}).execute()

        email_details = {
            "date": date,
            "sender_email": sender_email,
            "sender_name": sender_name,
            "subject": subject,
            "body": body
        }
        return email_details
    except HttpError as error:
        print(f'An error occurred: {error}')
        return None

def summarize_email(email_body):
    try:
        response = openai.Completion.create(
          engine="gpt-3.5-turbo-instruct",
          prompt=f"{promptinstructions}\n\n{email_body}",
          temperature=0.5,
          max_tokens=150,
          top_p=1.0,
          frequency_penalty=0.0,
          presence_penalty=0.0
        )
        summary = response.choices[0].text.strip()
        return summary
    except Exception as e:
        print(f"An error occurred during summarization: {e}")
        return "Summary unavailable."

def create_message(sender, to, subject, message_text):
    message = MIMEMultipart()
    message['to'] = to
    message['from'] = sender
    message['subject'] = subject

    msg = MIMEText(message_text, 'plain')
    message.attach(msg)

    return {'raw': base64.urlsafe_b64encode(message.as_string().encode()).decode()}

def send_message(service, user_id, message):
    try:
        message = (service.users().messages().send(userId=user_id, body=message).execute())
        print(f"Message Id: {message['id']}")
        return message
    except HttpError as error:
        print(f'An error occurred: {error}')
        return None

def main():
    creds = None
    if os.path.exists('token.pickle'):
        with open('token.pickle', 'rb') as token:
            creds = pickle.load(token)
    if not creds or not creds.valid:
        flow = InstalledAppFlow.from_client_secrets_file(
            "C:\\Users\\lukas\\OneDrive\\Desktop\\StartHack24\\credentials.json", SCOPES)
        creds = flow.run_local_server(port=0)
        with open('token.pickle', 'wb') as token:
            pickle.dump(creds, token)

    service = build('gmail', 'v1', credentials=creds)

    results = service.users().messages().list(userId='me', labelIds=['INBOX'], q="is:unread").execute()
    messages = results.get('messages', [])

    email_bodies = []
    sender_emails = []  # List to collect sender emails

    if not messages:
        print("No new messages found. No summary will be sent.")
    else:
        for message in messages:
            email_detail = get_email_details_and_mark_as_read(service, 'me', message['id'])
            if email_detail:
                email_bodies.append(email_detail['body'])
                sender_emails.append(email_detail['sender_email'])  # Add sender email to the list

        # Combine all emails into one large body of text to summarize
        combined_email_body = "\n\n".join(email_bodies)
        summary = summarize_email(combined_email_body)

        # Check if a summary is available before proceeding
        if summary != "Summary unavailable.":
            # Combine the original sender and additional recipients
            all_recipients = list_of_recipients + list(set(sender_emails))  # Remove duplicates with set()
            recipients = ", ".join(all_recipients)
            reply_subject = f"Aggregated Fellowship Alumni Updates for {datetime.now().strftime('%Y-%m-%d')}"
            reply_body = f"Here's a summary of the latest updates from our Fellowship Alumni:\n\n{summary}"
            reply_message = create_message("me", recipients, reply_subject, reply_body)
            send_message(service, "me", reply_message)
        else:
            print("Unable to generate a summary; no email will be sent.")

if __name__ == '__main__':
    main()