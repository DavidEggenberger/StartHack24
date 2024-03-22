using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Features.EFCore;
using Server.Features.Startups.Domain;
using Server.Features.WhatsAppMessaging;
using Shared.Founders;
using Shared.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Server.Features.Founders
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoundersController : ControllerBase
    {
        private ApplicationDbContext applicationDbContext;
        private InvitationCodesCollection invitationCodesCollection;
        private TwilioWhatsAppService TwilioWhatsAppService;

        public FoundersController(InvitationCodesCollection invitationCodesCollection, TwilioWhatsAppService TwilioWhatsAppService, ApplicationDbContext applicationDbContext)
        {
            this.invitationCodesCollection = invitationCodesCollection;
            this.applicationDbContext = applicationDbContext;
            this.TwilioWhatsAppService = TwilioWhatsAppService;
        }

        [HttpGet("count")]
        public async Task<int> GetFoundersCount()
        {
            return await applicationDbContext.Founders.CountAsync();
        }

        [HttpGet]
        public async Task<List<FounderDTO>> GetFounders()
        {
            return new List<FounderDTO> { new FounderDTO() { Name = "Sassy",  } };
        }

        [HttpGet("startup")]
        public async Task<ActionResult<StartupDTO>> GetStartupForFounderAsync()
        {
            var email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;

            var startup = await applicationDbContext.Startups
                .Where(s => s.FounderEmail == email)
                .FirstAsync();

            return new StartupDTO
            {
                Description = startup.Description,
                Discipline = startup.Discipline,
                Batch = startup.Batch,
                Location = startup.Location,
                Name = startup.Name,
                URI = startup.URI,
                Id = startup.Id,
            };
        }

        [HttpPost("{code}")]
        public async Task<ActionResult<StartupDTO>> CreateFounderWithStartup([FromRoute] string code, StartupDTO startup)
        {
            if (invitationCodesCollection.CheckIfValidCode(code) == false)
            {
                return Unauthorized();
            }

            var founderEmail = invitationCodesCollection.invitationCodes.FirstOrDefault(s => s.Item2.ToString() == code);

            var newStartUP = new StartUp
            {
                Name = startup.Name,
                URI = startup.URI,
                Location = startup.Location,
                FounderEmail = founderEmail.Item1
            };

            applicationDbContext.Startups.Add(newStartUP);
            await applicationDbContext.SaveChangesAsync();

            return Ok(startup);
        }

        [HttpGet("phoneNumber")]
        public async Task<string> GetPhoneNumber()
        {
            var email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;

            var founder = await applicationDbContext.Founders
                .Where(s => s.Email == email)
                .FirstAsync();

            return founder.MobileNumber;
        }

        [HttpGet("updatePhoneNumber/{number}")]
        public async Task<int> UpdatePhoneNumber(string number)
        {
            var email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;

            var founder = await applicationDbContext.Founders
                .Where(s => s.Email == email)
                .FirstAsync();

            founder.MobileNumber = number;

            try
            {
                TwilioWhatsAppService.SendMessage("Thanks for registrating with your phone number on FellowshipFinder! Whenever you have an update for your startup you can now write it in the chat. We then add it to the knowledge base.", founder.MobileNumber);
            }
            catch (Exception ex)
            {
                return 0;
            }

            founder.MobileEnabled = true;

            await applicationDbContext.SaveChangesAsync();

            return 0;
        }
    }
}
