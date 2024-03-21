using System;

namespace Server.Features.Startups.Domain
{
    public class StartUp
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string URI { get; set; }
        public string Location { get; set; }
        public string Discipline { get; set; }
    }
}
