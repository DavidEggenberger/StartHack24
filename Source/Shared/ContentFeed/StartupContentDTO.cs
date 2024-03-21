using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.ContentFeed
{
    public class StartupContentDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public NewsType Type { get; set; }
        public string Startup { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public Guid StartupId { get; set; }

        public override string ToString()
        {
            return Type + Startup + Description + Domain;
        }
    }
}
