﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Server.Features.UserIdentity.Domain;
using Shared.UserIdentity;
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

        public IdentityController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet("login/{provider}")]
        public async Task<ActionResult> LoginRedirectToExternalProvider([FromRoute] string provider)
        {
            if (provider == "Accelerator")
            {
                var identity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Accelerator Test Admin"),
                    new Claim(ClaimTypes.Role, "Accelerator")
                    
                }, IdentityConstants.ApplicationScheme);

                await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, new ClaimsPrincipal(identity));

                return Redirect("/");
            }

            if (provider == "Founder")
            {
                var identity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name, "Founder Test"),
                    new Claim(ClaimTypes.Role, "Founder")

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
    }
}