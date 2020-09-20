using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnHub.Entities;
using Microsoft.AspNet.Identity.EntityFramework;

namespace LearnHub.Repository
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext() :
            base("LearnHubDB")
        {

        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
    public class LearnHubContext : ApplicationDbContext
    {
        public DbSet<LKCategory> Category { get; set; }
        public DbSet<LKTag> Tag { get; set; }
        public DbSet<LKInstructor> Instructor { get; set; }
        public DbSet<LKPath> Path { get; set; }

        public DbSet<UserCourseRequest> CourseRequests { get; set; }
        public DbSet<UserFav> Favorites { get; set; }
        public DbSet<UserNotes> Notes { get; set; }


        public DbSet<HubCourses> Courses { get; set; }
        public DbSet<HubCoursesHeadTitles> CoursesHeads { get; set; }
        public DbSet<HubCoursesTitles> CoursesTitles { get; set; }

        public DbSet<UserCourses> UserCourses { get; set; }
        public DbSet<UserPathes> UserPathes { get; set; }

    }
}
