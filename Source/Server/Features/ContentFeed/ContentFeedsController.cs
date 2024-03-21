using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Server.Features.EFCore;
using Shared.ContentFeed;
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

        [HttpPost]
        public async Task<ActionResult<ContentFeedDTO>> CreateContentFeed(ContentFeedDTO contentFeedDTO)
        {
            var startupContent = new StartupContent
            {

            };

            applicationDbContext.StartupContents.Add(startupContent);

            await applicationDbContext.SaveChangesAsync();

            return Ok(contentFeedDTO);
        }
    }
}
