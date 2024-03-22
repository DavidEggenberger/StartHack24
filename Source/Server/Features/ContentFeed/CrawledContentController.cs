using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Server.Features.EFCore;
using Server.Hubs;
using Shared.ContentFeed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Features.ContentFeed
{
    [Route("api/[controller]")]
    [ApiController]
    public class CrawledContentController : ControllerBase
    {
        private ApplicationDbContext ApplicationDbContext;
        private IHubContext<NotificationHub> HubContext;
        public CrawledContentController(IHubContext<NotificationHub> HubContext, ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.HubContext = HubContext;
        }

        [HttpGet]
        public async Task<List<CrawledContentDTO>> Get()
        {
            return ApplicationDbContext.CrawledContents.Where(c => c.Ignored == false).Select(c => new CrawledContentDTO
            {
                Id = c.Id,
                Startup = c.Startup,
                Content = c.Content,
                Date = c.Date,
                Title = c.Title,
                Type = c.Type,
            }).ToList();
        }

        [HttpPost("{contentId}")]
        public async Task MoveAsync(Guid contentId)
        {
            var content = ApplicationDbContext.CrawledContents.SingleOrDefault(s => s.Id == contentId);

            ApplicationDbContext.CrawledContents.Remove(content);

            await ApplicationDbContext.SaveChangesAsync();

            await HubContext.Clients.All.SendAsync("crawledupdate");
        }

        [HttpDelete("{contentId}")]
        public async Task DeleteAsync(Guid contentId)
        {
            var content = ApplicationDbContext.CrawledContents.SingleOrDefault(s => s.Id == contentId);

            content.Ignored = true;

            await ApplicationDbContext.SaveChangesAsync();

            await HubContext.Clients.All.SendAsync("crawledupdate");
        }
    }
}
