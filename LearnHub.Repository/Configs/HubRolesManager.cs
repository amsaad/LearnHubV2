
using LearnHub.Entities;
using LearnHub.Repository;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace LearnHub.Configs
{
    public class HubRolesManager : RoleManager<AppRole, string>
    {
        public static HubRolesManager Creat(IOwinContext context)
        {
            return new HubRolesManager(new RoleStore<AppRole>(context.Get<HubContext>()));
        }
        public HubRolesManager(IRoleStore<AppRole, string> store)
            : base(store)
        {
        }
        public static HubRolesManager Create(IdentityFactoryOptions<HubRolesManager> options, IOwinContext context)
        {
            return new HubRolesManager(new RoleStore<AppRole>(context.Get<HubContext>()));
        }

    }
}