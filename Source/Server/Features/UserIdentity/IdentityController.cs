using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using Server.Features.UserIdentity.Domain;
using Shared.UserIdentity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Server.Features.UserIdentity
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private SignInManager<ApplicationUser> signInManager;
        private UserManager<ApplicationUser> userManager;
        private EmailSender emailSender;
        private InvitationCodesCollection invitationCodesCollection;
        private IWebHostEnvironment webHostEnvironment;

        public IdentityController(SignInManager<ApplicationUser> signInManager, IWebHostEnvironment webHostEnvironment, UserManager<ApplicationUser> userManager, InvitationCodesCollection invitationCodesCollection, EmailSender emailSender)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.emailSender = emailSender;
            this.invitationCodesCollection = invitationCodesCollection;
            this.webHostEnvironment = webHostEnvironment;
        }

        [HttpGet("login/{provider}")]
        public async Task<ActionResult> LoginRedirectToExternalProvider([FromRoute] string provider)
        {
            if (provider == "Accelerator")
            {
                var identity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Accelerator Test Admin"),
                    new Claim(ClaimTypes.Role, "Accelerator"),
                    
                }, IdentityConstants.ApplicationScheme);

                await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(identity));

                return Redirect("/");
            }

            if (provider == "Founder")
            {
                var identity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Founder Test"),
                    new Claim(ClaimTypes.Role, "Founder"),
                    new Claim(ClaimTypes.Email, "test.founder@fellowship.com")

                }, IdentityConstants.ApplicationScheme);

                await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(identity));

                return Redirect("/");
            }

            var redirectUrl = Url.Action("ExternalLoginCallback");
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return Challenge(properties, provider);
        }

        [HttpGet("BFFUser")]
        [AllowAnonymous]
        public ActionResult<BFFUserInfoDTO> GetCurrentUser()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return BFFUserInfoDTO.Anonymous;
            }

            return new BFFUserInfoDTO()
            {
                Claims = User.Claims.Select(claim => new ClaimValueDTO { Type = claim.Type, Value = claim.Value }).ToList()
            };
        }

        [Authorize]
        [HttpGet("Logout")]
        public async Task<ActionResult> LogoutCurrentUser()
        {
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);
            return Redirect("/");
        }

        [HttpPost]
        public async Task InviteUser([FromBody] InviteUserDTO inviteUserDTO)
        {
            var invitationCode = Guid.NewGuid();
            invitationCodesCollection.AddInvitationCode(inviteUserDTO.Email, invitationCode);

            var message = $@"
                <h3>You are invited as a {inviteUserDTO.Type} to Fellowship Finder</h3>
                <h5><a href='{(webHostEnvironment.IsDevelopment() ? $"https://localhost:44324/invitationLink/{invitationCode}" : "")}' />Please visit the link to finish your registration</h5>
            ";

            await emailSender.SendEmailAsync(inviteUserDTO.Type, message, inviteUserDTO.Email);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string ReturnUrl = null)
        {
            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info.Principal == null)
            {
                return Redirect("/User/Login");
            }
            var user = await userManager.FindByNameAsync(info.Principal.Identity.Name);
            if (info is not null && user is null)
            {
                ApplicationUser _user = new ApplicationUser
                {
                    UserName = info.Principal.Identity.Name,
                    PictureURI = info.Principal.Claims.Where(claim => claim.Type == "picture").First().Value
                };

                var result = await userManager.CreateAsync(_user);

                if (result.Succeeded)
                {
                    result = await userManager.AddLoginAsync(_user, info);
                    await signInManager.SignInAsync(_user, isPersistent: false, info.LoginProvider);
                    return LocalRedirect("/");
                }
            }

            string pictureURI = info.Principal.Claims.Where(claim => claim.Type == "picture").First().Value;
            if (user.PictureURI != pictureURI)
            {
                user.PictureURI = pictureURI;
                await userManager.UpdateAsync(user);
            }

            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: false);
            return signInResult switch
            {
                Microsoft.AspNetCore.Identity.SignInResult { Succeeded: true } => LocalRedirect("/"),
                _ => Redirect("/Error")
            };
        }
    }
}
