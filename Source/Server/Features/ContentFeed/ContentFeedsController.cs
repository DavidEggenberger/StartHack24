using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.ContentFeed;
using System.Threading.Tasks;

namespace Server.Features.ContentFeed
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentFeedsController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<ContentFeedDTO>> CreateContentFeed(ContentFeedDTO contentFeedDTO)
        {

            return Ok(contentFeedDTO);
        }
    }
}
