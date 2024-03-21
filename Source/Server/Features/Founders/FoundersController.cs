using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public async Task<List<FounderDTO>> GetFounders()
        {
            return new List<FounderDTO> { new FounderDTO() { Name = "Sassy",  } };
        }
    }
}
