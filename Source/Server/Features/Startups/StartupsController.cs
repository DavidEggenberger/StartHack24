using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Startup;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Features.Startups
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartupsController : ControllerBase
    {
        [HttpGet]
        public async Task<List<StartupDTO>> GetStartups()
        {
            return new List<StartupDTO> { new StartupDTO() { Name = "Sassy", Discipline = DisciplineDTO.SaaS } };
        }
    }
}
