namespace LearnHub.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestructTables : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.CourseRequests", newName: "UserCourseRequests");
            RenameTable(name: "dbo.Courses", newName: "HubCourses");
            RenameTable(name: "dbo.CourseHeadTitles", newName: "HubCoursesHeadTitles");
            RenameTable(name: "dbo.CourseTitles", newName: "HubCoursesTitles");
            CreateTable(
                "dbo.UserCourses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EnrollmentState = c.Int(nullable: false),
                        UserID = c.String(maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Course_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.HubCourses", t => t.Course_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.Course_ID);
            
            CreateTable(
                "dbo.UserPathes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EnrollmentState = c.Int(nullable: false),
                        UserID = c.String(maxLength: 128),
                        CreationDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(),
                        Course_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.LKPaths", t => t.Course_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.UserID)
                .Index(t => t.UserID)
                .Index(t => t.Course_ID);
            
            AddColumn("dbo.LKCategories", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.UserCourseRequests", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.HubCourses", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.LKInstructors", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.HubCoursesHeadTitles", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.HubCoursesTitles", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.UserFavs", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.UserNotes", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.LKPaths", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetRoles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.LKTags", "UserID", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "MaxSessionsSimultaneous", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "IsSignedIn", c => c.Boolean(nullable: false));
            AlterColumn("dbo.HubCourses", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.HubCourses", "Description", c => c.String());
            AlterColumn("dbo.HubCoursesHeadTitles", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.HubCoursesTitles", "Title", c => c.String(nullable: false));
            CreateIndex("dbo.LKCategories", "UserID");
            CreateIndex("dbo.UserCourseRequests", "UserID");
            CreateIndex("dbo.HubCourses", "UserID");
            CreateIndex("dbo.LKInstructors", "UserID");
            CreateIndex("dbo.HubCoursesHeadTitles", "UserID");
            CreateIndex("dbo.HubCoursesTitles", "UserID");
            CreateIndex("dbo.UserFavs", "UserID");
            CreateIndex("dbo.UserNotes", "UserID");
            CreateIndex("dbo.LKPaths", "UserID");
            CreateIndex("dbo.LKTags", "UserID");
            AddForeignKey("dbo.LKCategories", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UserCourseRequests", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.LKInstructors", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.HubCourses", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.HubCoursesHeadTitles", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.HubCoursesTitles", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UserFavs", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.UserNotes", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.LKPaths", "UserID", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.LKTags", "UserID", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.LKPaths", "CoursesCounter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LKPaths", "CoursesCounter", c => c.Int(nullable: false));
            DropForeignKey("dbo.UserPathes", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserPathes", "Course_ID", "dbo.LKPaths");
            DropForeignKey("dbo.UserCourses", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserCourses", "Course_ID", "dbo.HubCourses");
            DropForeignKey("dbo.LKTags", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.LKPaths", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserNotes", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserFavs", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.HubCoursesTitles", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.HubCoursesHeadTitles", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.HubCourses", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.LKInstructors", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserCourseRequests", "UserID", "dbo.AspNetUsers");
            DropForeignKey("dbo.LKCategories", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.UserPathes", new[] { "Course_ID" });
            DropIndex("dbo.UserPathes", new[] { "UserID" });
            DropIndex("dbo.UserCourses", new[] { "Course_ID" });
            DropIndex("dbo.UserCourses", new[] { "UserID" });
            DropIndex("dbo.LKTags", new[] { "UserID" });
            DropIndex("dbo.LKPaths", new[] { "UserID" });
            DropIndex("dbo.UserNotes", new[] { "UserID" });
            DropIndex("dbo.UserFavs", new[] { "UserID" });
            DropIndex("dbo.HubCoursesTitles", new[] { "UserID" });
            DropIndex("dbo.HubCoursesHeadTitles", new[] { "UserID" });
            DropIndex("dbo.LKInstructors", new[] { "UserID" });
            DropIndex("dbo.HubCourses", new[] { "UserID" });
            DropIndex("dbo.UserCourseRequests", new[] { "UserID" });
            DropIndex("dbo.LKCategories", new[] { "UserID" });
            AlterColumn("dbo.HubCoursesTitles", "Title", c => c.String());
            AlterColumn("dbo.HubCoursesHeadTitles", "Title", c => c.String());
            AlterColumn("dbo.HubCourses", "Description", c => c.DateTime(nullable: false));
            AlterColumn("dbo.HubCourses", "Title", c => c.String());
            DropColumn("dbo.AspNetUsers", "IsSignedIn");
            DropColumn("dbo.AspNetUsers", "MaxSessionsSimultaneous");
            DropColumn("dbo.LKTags", "UserID");
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropColumn("dbo.LKPaths", "UserID");
            DropColumn("dbo.UserNotes", "UserID");
            DropColumn("dbo.UserFavs", "UserID");
            DropColumn("dbo.HubCoursesTitles", "UserID");
            DropColumn("dbo.HubCoursesHeadTitles", "UserID");
            DropColumn("dbo.LKInstructors", "UserID");
            DropColumn("dbo.HubCourses", "UserID");
            DropColumn("dbo.UserCourseRequests", "UserID");
            DropColumn("dbo.LKCategories", "UserID");
            DropTable("dbo.UserPathes");
            DropTable("dbo.UserCourses");
            RenameTable(name: "dbo.HubCoursesTitles", newName: "CourseTitles");
            RenameTable(name: "dbo.HubCoursesHeadTitles", newName: "CourseHeadTitles");
            RenameTable(name: "dbo.HubCourses", newName: "Courses");
            RenameTable(name: "dbo.UserCourseRequests", newName: "CourseRequests");
        }
    }
}
