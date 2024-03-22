using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Features.EFCore;
using Shared.ContentFeed;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Features.ContentFeed
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentFeedsController : ControllerBase
    {
        private ApplicationDbContext applicationDbContext;

        public ContentFeedsController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<StartupContentDTO>>> GetContents()
        {
            return Ok(applicationDbContext.StartupContents.Select(s => new StartupContentDTO
            {
                Date = s.Date,
                Description = s.Description,
                Startup = s.Startup,
                Id = s.Id,
                Type = s.Type
            }).ToList());
        }

        [HttpGet("count")]
        public async Task<ActionResult<int>> GetContentsCount()
        {
            return Ok(applicationDbContext.StartupContents.Count());
        }

        [HttpPost]
        public async Task<ActionResult<ContentFeedDTO>> CreateContentFeed(ContentFeedDTO contentFeedDTO)
        {
            var startupContent = new StartupContent
            {
                Date = contentFeedDTO.Date,
                Domain = contentFeedDTO.Domain,
                Description = contentFeedDTO.Content,
                Title = contentFeedDTO.Title
            };

            applicationDbContext.StartupContents.Add(startupContent);

            await applicationDbContext.SaveChangesAsync();

            return Ok(contentFeedDTO);
        }
    }
}

