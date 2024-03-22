using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ContentFeed
{
    public class CrawledContentDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Startup { get; set; }
        public NewsType Type { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Ignored { get; set; }
    }
}
