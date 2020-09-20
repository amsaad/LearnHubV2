namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class appsettings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppSettings",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IsRegistrationOpen = c.Boolean(nullable: false),
                        IsRegistrationRequiredApproval = c.Boolean(nullable: false),
                        UserID = c.String(maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppSettings", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.AppSettings", new[] { "UserID" });
            DropTable("dbo.AppSettings");
        }
    }
}
