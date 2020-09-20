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

namespace LearnHub.WebV1.Controllers
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
                return _roleManager ?? HttpContext.GetOwinContext().Get<HubRolesManager>();
            }
            private set
            {
                _roleManager = value;
            }
        }
        // GET: Install
        public async Task<ActionResult> Index()
        {
            using (var db = new LearnHub.Repository.LearnHubContext())
            {
                var settings = db.SysSettings.FirstOrDefault();
                if (settings == null)
                {
                    var user = new Entities.AppUser()
                    {
                        UserName = "amsaad",
                        Email = "ashoooh@gmail.com",
                        EmailConfirmed = true,
                        MaxSessionsSimultaneous = int.MaxValue,
                        MustChangePassword = true
                    };
                    var userResult = await UserManager.CreateAsync(user, "Learnhub@123");
                    if (userResult.Succeeded)
                    {
                        if (!await RolesManager.RoleExistsAsync(SystemRoles.SysAdmin.ToString()))
                        {
                            RolesManager.Create(new AppRole()
                            {
                                Name = SystemRoles.SysAdmin.ToString()
                            });
                        }
                        var currentUser = UserManager.FindByName(user.UserName);
                        await UserManager.AddToRoleAsync(currentUser.Id, SystemRoles.SysAdmin.ToString());
                        db.SysSettings.Add(new Entities.AppSettings()
                        {
                            UserID = currentUser.Id,
                            IsRegistrationOpen = false,
                            IsRegistrationRequiredApproval = true,
                        });
                        await db.SaveChangesAsync();
                        //await SignInManager.SignInAsync(user, isPersistent: false, false);
                        return RedirectToAction("Login", "Account");
                    }
                }
            }
            return View();
        }
    }
}