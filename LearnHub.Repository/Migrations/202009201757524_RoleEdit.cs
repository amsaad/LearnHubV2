namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleEdit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "RoleValue", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "RoleValue");
        }
    }
}
