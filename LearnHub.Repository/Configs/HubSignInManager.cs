using LearnHub.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LearnHub.Configs
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

        public async Task<AppSignInStatus> EmailSignInAsync(string Email, string password, bool isPersistent, bool shouldLockout)
        {
            var user = await UserManager.FindByEmailAsync(Email);
            if (user == null)
            {
                return AppSignInStatus.Failure;
            }

            return await AppPasswordSignInAsync(user.UserName, password, isPersistent, shouldLockout);
        }

        public async Task<AppSignInStatus> AppPasswordSignInAsync(string userName, string password, bool isPersistent, bool shouldLockout)
        {
            var user = await UserManager.FindByNameAsync(userName);
            if (user == null)
            {
                return AppSignInStatus.Failure;
            }

            var result = await base.PasswordSignInAsync(userName, password, isPersistent, shouldLockout);
            if (result == SignInStatus.Success)
            {
                if (user.MustChangePassword)
                {
                    return AppSignInStatus.MustChangePassword;
                }
            }
            return (AppSignInStatus)(int)result;
        }

        public static HubSignInManager Create(IdentityFactoryOptions<HubSignInManager> options, IOwinContext context)
        {
            return new HubSignInManager(context.GetUserManager<HubUserManager>(), context.Authentication);
        }
    }
}