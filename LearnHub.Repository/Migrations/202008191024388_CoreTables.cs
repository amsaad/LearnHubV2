namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CoreTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.DateTime(nullable: false),
                        ImgID = c.String(),
                        LikesCounter = c.Int(nullable: false),
                        RestrictionCode = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ExternalLink = c.String(),
                        RepositoryLink = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Instructor_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LKInstructors", t => t.Instructor_ID)
                .Index(t => t.Instructor_ID);
            
            CreateTable(
                "dbo.CourseHeadTitles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ThumbSrc = c.String(),
                        TotalDuration = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Course_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Courses", t => t.Course_ID)
                .Index(t => t.Course_ID);
            
            CreateTable(
                "dbo.CourseTitles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        TitleType = c.Int(nullable: false),
                        SrcLink = c.String(),
                        ThumbSrc = c.String(),
                        Duration = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        HeadTitle_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CourseHeadTitles", t => t.HeadTitle_ID)
                .Index(t => t.HeadTitle_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseTitles", "HeadTitle_ID", "dbo.CourseHeadTitles");
            DropForeignKey("dbo.CourseHeadTitles", "Course_ID", "dbo.Courses");
            DropForeignKey("dbo.Courses", "Instructor_ID", "dbo.LKInstructors");
            DropIndex("dbo.CourseTitles", new[] { "HeadTitle_ID" });
            DropIndex("dbo.CourseHeadTitles", new[] { "Course_ID" });
            DropIndex("dbo.Courses", new[] { "Instructor_ID" });
            DropTable("dbo.CourseTitles");
            DropTable("dbo.CourseHeadTitles");
            DropTable("dbo.Courses");
        }
    }
}
