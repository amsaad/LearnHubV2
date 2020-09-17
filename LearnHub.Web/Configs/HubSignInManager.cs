using LearnHub.Entities;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace LearnHub.Web.Configs
{
    public class HubSignInManager : SignInManager<AppUser, string>
    {
        public HubSignInManager(HubUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(AppUser user)
        {
            return user.GenerateUserIdentityAsync((HubUserManager)UserManager);
        }

        public static HubSignInManager Create(IdentityFactoryOptions<HubSignInManager> options, IOwinContext context)
        {
            return new HubSignInManager(context.GetUserManager<HubUserManager>(), context.Authentication);
        }
    }
}