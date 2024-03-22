using Shared.ContentFeed;
using System;

namespace Server.Features.ContentFeed
{
    public class StartupContent
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public NewsType Type { get; set; }
        public string Startup { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public string Title { get; set; }
        public Guid StartupId { get; set; }
    }
}

