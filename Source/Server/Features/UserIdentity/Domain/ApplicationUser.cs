using Microsoft.AspNetCore.Identity;

namespace Server.Features.UserIdentity.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public UserType UserType { get; set; }
        public string PictureURI { get; set; }
    }
}
