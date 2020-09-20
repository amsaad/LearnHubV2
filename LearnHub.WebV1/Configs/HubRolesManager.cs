
using LearnHub.Entities;
using LearnHub.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnHub.Web.Configs
{
    public class HubRolesManager : RoleManager<AppRole, string>
    {
        public HubRolesManager(IRoleStore<AppRole, string> store)
            : base(store)
        {
        }
        public static HubRolesManager Create(IdentityFactoryOptions<HubRolesManager> options, IOwinContext context)
        {
            return new HubRolesManager(new RoleStore<AppRole>(context.Get<LearnHubContext>()));
        }

    }
}