using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UserIdentity
{
    public class UserDTO
    {
        public string Id { get; set; }
        public string PictureURI { get; set; }
        public string UserName { get; set; }
        public bool IsOnline { get; set; }
    }
}
