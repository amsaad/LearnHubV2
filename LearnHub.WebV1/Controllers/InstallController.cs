using LearnHub.Entities;
using LearnHub.Web.Configs;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LearnHub.Configs;
using LearnHub.Repository;

namespace LearnHub.Web.Controllers
{
    public class InstallController : Controller
    {
        private HubSignInManager _signInManager;
        private HubUserManager _userManager;
        private HubRolesManager _roleManager;
        public HubSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<HubSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public HubUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<HubUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        public HubRolesManager RolesManager
        {
            get
            {
                return _roleManager ?? HubRolesManager.Creat(HttpContext.GetOwinContext());
            }
            private set
            {
                _roleManager = value;
            }
        }
        // GET: Install
        public async Task<ActionResult> Index()
        {

            using (var repo = new AppSettingsRepo())
            {
                var r = await repo.GetAllAsync();
                if (r.Count() > 0)
                {
                    return RedirectToAction("Login", "Account");
                }
            }

            //Create first user
            var user = new AppUser()
            {
                UserName = "amsaad",
                Email = "ashoooh@gmail.com",
                EmailConfirmed = true,
                MaxSessionsSimultaneous = int.MaxValue,
                MustChangePassword = true
            };
            //var userResult = await UserManager.CreateAsync(user, "Learnhub@123");
            var currentUser = UserManager.FindByName(user.UserName);

            if (currentUser!=null)
            {
                bool RoleExist = await RolesManager.RoleExistsAsync(SystemRoles.SysAdmin.ToString());
                //If admin role not exist
                if (!RoleExist)
                {
                    RolesManager.Create(new AppRole()
                    {

                        Name = SystemRoles.SysAdmin.ToString()
                    });
                }
                //var currentUser = UserManager.FindByName(user.UserName);
                await UserManager.AddToRoleAsync(currentUser.Id, SystemRoles.SysAdmin.ToString());

                using (var repo = new AppSettingsRepo())
                {
                    repo.Add(new Entities.AppSettings()
                    {
                        UserID = currentUser.Id,
                        IsRegistrationOpen = false,
                        IsRegistrationRequiredApproval = true,
                    });
                    await repo.SaveAsync();
                }
            }
            return RedirectToAction("Login", "Account");
        }
    }
}