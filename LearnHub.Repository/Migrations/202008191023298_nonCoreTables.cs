namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nonCoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseRequests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        CourseName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserFavs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EntityID = c.Int(nullable: false),
                        EntityType = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserNotes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        EntityID = c.Int(nullable: false),
                        EntityType = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserNotes");
            DropTable("dbo.UserFavs");
            DropTable("dbo.CourseRequests");
        }
    }
}
