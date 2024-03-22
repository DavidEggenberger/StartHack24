using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Server.Features.EFCore;
using Server.Hubs;
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
        private IHubContext<NotificationHub> hubContext;

        public ContentFeedsController(ApplicationDbContext applicationDbContext, IHubContext<NotificationHub> hubContext)
        {
            this.applicationDbContext = applicationDbContext;
            this.hubContext = hubContext;
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
            var startupContent = new CrawledContent
            {
                Date = contentFeedDTO.Date,
                Startup = contentFeedDTO.Domain,
                Content = contentFeedDTO.Content,
                Title = contentFeedDTO.Title
            };

            applicationDbContext.CrawledContents.Add(startupContent);

            await applicationDbContext.SaveChangesAsync();

            await hubContext.Clients.All.SendAsync("crawledupdate");

            return Ok(contentFeedDTO);
        }
    }
}

