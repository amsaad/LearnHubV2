namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lookupsv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LKCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CoursesCounter = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LKInstructors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CoursesCounter = c.Int(nullable: false),
                        About = c.String(),
                        ImgID = c.String(),
                        Rank = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LKPaths",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CertName = c.String(),
                        About = c.String(),
                        CoursesCounter = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.LKTags",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LKTags");
            DropTable("dbo.LKPaths");
            DropTable("dbo.LKInstructors");
            DropTable("dbo.LKCategories");
        }
    }
}
