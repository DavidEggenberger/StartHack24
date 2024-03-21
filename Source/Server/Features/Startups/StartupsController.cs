using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Server.Features.EFCore;
using Server.Features.Startups.Domain;
using Server.Hubs;
using Shared.Startup;
using System.Collections.Generic;
using System.Linq;
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
                Batch = s.Batch
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

        [HttpDelete]
        public async Task DeleteAllStartups()
        {
            applicationDbContext.Startups.ExecuteDelete();

            await applicationDbContext.SaveChangesAsync();
        }
    }
}
