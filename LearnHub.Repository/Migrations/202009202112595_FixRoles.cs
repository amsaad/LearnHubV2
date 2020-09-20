namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MustChangePassword", c => c.Boolean(nullable: false));
            DropColumn("dbo.AspNetRoles", "RoleValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetRoles", "RoleValue", c => c.Int());
            DropColumn("dbo.AspNetUsers", "MustChangePassword");
        }
    }
}
