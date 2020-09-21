namespace LearnHub.Repository.Migrations
{
    using LearnHub.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LearnHub.Repository.HubContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LearnHub.Repository.HubContext context)
        {
            //  This method will be called after migrating to the latest version.
            //if (context.Roles.Count() != 0)
            //{
            //    context.Roles.AddOrUpdate(new AppRole() { });
            //    context.Roles.AddOrUpdate(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole("SuperUser"));
            //    context.Roles.AddOrUpdate(new Microsoft.AspNet.Identity.EntityFramework.IdentityRole("User"));
            //    context.SysSettings.Add(new Entities.AppSettings { IsRegistrationOpen = false, IsRegistrationRequiredApproval = true });
            //}

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
