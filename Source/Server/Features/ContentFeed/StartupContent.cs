using Shared.ContentFeed;
using System;

namespace Server.Features.ContentFeed
{
    public class StartupContent
    {
        public Guid Id { get; set; }
        public NewsType Type { get; set; }
        public string Domain { get; set; }
    }
}
