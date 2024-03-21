using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Features.EFCore;
using Server.Features.Startups.Domain;
using Shared.Founders;
using Shared.Startup;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Features.Founders
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoundersController : ControllerBase
    {
        private ApplicationDbContext applicationDbContext;
        private InvitationCodesCollection invitationCodesCollection;

        public FoundersController(InvitationCodesCollection invitationCodesCollection, ApplicationDbContext applicationDbContext)
        {
            this.invitationCodesCollection = invitationCodesCollection;
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<List<FounderDTO>> GetFounders()
        {
            return new List<FounderDTO> { new FounderDTO() { Name = "Sassy",  } };
        }

        [HttpPost("{code}")]
        public async Task<ActionResult<StartupDTO>> CreateFounderWithStartup([FromRoute] string code, StartupDTO startup)
        {
            if (invitationCodesCollection.CheckIfValidCode(code) == false)
            {
                return Unauthorized();
            }

            var newStartUP = new StartUp
            {
                Name = startup.Name,
                URI = startup.URI,
                Location = startup.Location,
            };

            applicationDbContext.Startups.Add(newStartUP);
            await applicationDbContext.SaveChangesAsync();

            return Ok(startup);
        }
    }
}
