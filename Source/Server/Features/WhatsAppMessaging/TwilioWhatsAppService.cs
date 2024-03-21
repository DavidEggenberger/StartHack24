using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Server.Features.WhatsAppMessaging
{
    public class TwilioWhatsAppService
    {
        private IConfiguration configuration;
        public TwilioWhatsAppService(IConfiguration configuration)
        {
            this.configuration = configuration;
            TwilioClient.Init(configuration["TwilioAccountSid"], configuration["TwilioAccountToken"]);
        }
        public void SendMessage(string message, string number)
        {
            var v = MessageResource.Create(
            body: message,
            from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
            to: new Twilio.Types.PhoneNumber($"whatsapp:+{number}"));
        }
    }
}
