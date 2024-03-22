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
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Server.Features.ContentFeed;
using Microsoft.AspNetCore.SignalR;
using Server.Hubs;

namespace Server.Features.WhatsAppMessaging
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioWebHook : ControllerBase
    {
        private ApplicationDbContext ApplicationDbContext;
        private IHubContext<NotificationHub> hubContext;
        public TwilioWebHook(ApplicationDbContext ApplicationDbContext, IHubContext<NotificationHub> hubContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.hubContext = hubContext;
        }

        [HttpPost]
        public async Task<ActionResult> Create()
        {
            var requestBody = Request.Form["Body"];

            //var mobileNumber = Request.Form["From"].ToString().Replace("+", "");

            //var founder = await ApplicationDbContext.Founders.Where(f => f.MobileNumber == mobileNumber).FirstOrDefaultAsync();

            //var startUp = await ApplicationDbContext.Startups.Where(s => s.FounderEmail == founder.Email).FirstOrDefaultAsync(); 

            ApplicationDbContext.CrawledContents.Add(new CrawledContent { Content = requestBody, Startup = "startUp.Name"});

            await ApplicationDbContext.SaveChangesAsync();

            await hubContext.Clients.All.SendAsync("crawledupdate");

            return Ok();
        }
    }
}
