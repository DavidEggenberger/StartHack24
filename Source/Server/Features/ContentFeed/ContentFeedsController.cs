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
            return Ok(new List<StartupContentDTO>
            {
                new StartupContentDTO
                {
                    Date = System.DateTime.Now.AddDays(-5),
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team,
                    StartupId = new System.Guid("1549bff0-1f1b-4d05-9266-50f266ff6075")
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Funding
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup and then many more people brought the product",
                    Type = NewsType.Achievement
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.ESG
                },new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                },
                new StartupContentDTO
                {
                    Date = System.DateTime.Now,
                    Startup = "New Startup",
                    Description = "Event of the startup",
                    Type = NewsType.Team
                }
            });
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
