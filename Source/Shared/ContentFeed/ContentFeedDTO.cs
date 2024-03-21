using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ContentFeed
{
    public class ContentFeedDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string Domain { get; set; }
    }
}
