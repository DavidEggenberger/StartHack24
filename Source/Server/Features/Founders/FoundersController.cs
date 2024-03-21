using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Features.EFCore;
using Server.Features.Startups.Domain;
using Shared.Founders;
using Shared.Startup;
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

        public FoundersController(InvitationCodesCollection invitationCodesCollection, ApplicationDbContext applicationDbContext)
        {
            this.invitationCodesCollection = invitationCodesCollection;
            this.applicationDbContext = applicationDbContext;
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
    }
}
