using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System;
using Twilio.TwiML.Messaging;
using Twilio.TwiML;
using Twilio.AspNet.Core;
using System.Threading.Tasks;
using Server.Features.EFCore;

namespace Server.Features.WhatsAppMessaging
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioWebHook : ControllerBase
    {
        private ApplicationDbContext ApplicationDbContext;

        public TwilioWebHook(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
        }

        [HttpPost]
        public async Task<ActionResult> Create()
        {
            var requestBody = Request.Form["Body"];
            var response = new MessagingResponse();
            if (requestBody == "hello")
            {
                response.Message("Hi!");
            }
            else if (requestBody == "bye")
            {
                response.Message("Goodbye");
            }

            ApplicationDbContext.StartupContents.Add(new ContentFeed.StartupContent { Description = requestBody });

            await ApplicationDbContext.SaveChangesAsync();

            return Ok();
        }
    }
}
