using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Startup
{
    public class StartupDTO : FounderStartupBaseDTO
    {
        public string Name { get; set; }
        public string URI { get; set; }
        public string Location { get; set; }
        public DisciplineDTO Discipline { get; set; }
    }
}
