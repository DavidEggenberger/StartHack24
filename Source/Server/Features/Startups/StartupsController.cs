using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Server.Features.EFCore;
using Server.Features.Startups.Domain;
using Server.Hubs;
using Shared.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Server.Features.Startups
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartupsController : ControllerBase
    {
        private ApplicationDbContext applicationDbContext;
        private IHubContext<NotificationHub> hubContext;

        public StartupsController(ApplicationDbContext applicationDbContext, IHubContext<NotificationHub> hubContext)
        {
            this.applicationDbContext = applicationDbContext;   
            this.hubContext = hubContext;
        }

        [HttpGet]
        public async Task<List<StartupDTO>> GetStartups()
        {
            return applicationDbContext.Startups.Select(s => new StartupDTO
            {
                Location = s.Location,
                URI = s.URI,
                Discipline = s.Discipline,
                Name = s.Name,
                Description = s.Description,
                Batch = s.Batch,
                Id = s.Id,
            }).ToList();
        }

        [HttpGet("count")]
        public async Task<int> GetFoundersCount()
        {
            return await applicationDbContext.Startups.CountAsync();
        }

        [HttpPost]
        public async Task<ActionResult> CreateStartup(StartupDTO startupDTO)
        {
            var startup = new StartUp
            {
                Location = startupDTO.Location,
                Name = startupDTO.Name,
                URI = startupDTO.URI,
                Discipline = startupDTO.Discipline,
                Description = startupDTO.Description,
                Batch = startupDTO.Batch
            };

            applicationDbContext.Startups.Add(startup);

            await applicationDbContext.SaveChangesAsync();

            await hubContext.Clients.All.SendAsync("StartupChange");

            return Ok();
        }

        [HttpPost("Update")]
        public async Task<ActionResult> UpdateStartupAsync(StartupDTO startupDTO)
        {
            var startup = await applicationDbContext.Startups.FirstOrDefaultAsync(s => s.Id == startupDTO.Id);

            var email = User.Claims.First(c => c.Type == ClaimTypes.Email).Value;

            if (startup.FounderEmail != email)
            {
                return Unauthorized();
            }

            startup.URI = startupDTO.URI;
            startup.Name = startupDTO.Name;
            startup.Discipline = startupDTO.Discipline;
            startup.Description = startupDTO.Description;
            startup.Batch = startupDTO.Batch;
            startup.Location = startupDTO.Location;
            startup.URI = startup.URI;

            await applicationDbContext.SaveChangesAsync();

            return Ok();

        }

        [HttpDelete]
        public async Task DeleteAllStartups()
        {
            applicationDbContext.Startups.ExecuteDelete();

            await applicationDbContext.SaveChangesAsync();
        }

        [HttpGet("founderNumber/{startupId}")]
        public async Task<string> GetMobilePhoneOfFounder([FromRoute] Guid startupId)
        {
            var startup = await applicationDbContext.Startups.FirstAsync(s => s.Id == startupId);

            var email = startup.FounderEmail;

            var founder = await applicationDbContext.Founders.FirstAsync(f => f.Email == email);

            return founder.MobileNumber;

        }
    }
}
