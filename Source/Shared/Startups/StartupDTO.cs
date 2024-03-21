using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Startup
{
    public class StartupDTO : FounderStartupBaseDTO
    {
        public Guid Id { get; set; }
        public string FounderName { get; set; }
        public string URI { get; set; }
        public string Discipline { get; set; }
        public string Description { get; set; }
        public string Batch { get; set; }

        public override string ToString()
        {
            return FounderName + URI + Discipline + Name;
        }
    }
}
