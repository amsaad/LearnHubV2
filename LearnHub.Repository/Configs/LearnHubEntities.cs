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
    public class ApplicationDbContext : IdentityDbContext<UserIdentity>
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
    public class LearnHubEntities : ApplicationDbContext
    {
        public DbSet<LKCategory> Category { get; set; }
        public DbSet<LKTag> Tag { get; set; }
        public DbSet<LKInstructor> Instructor { get; set; }
        public DbSet<LKPath> Path { get; set; }

        public DbSet<CourseRequest> CourseRequests { get; set; }
        public DbSet<UserFav> Favorites { get; set; }
        public DbSet<UserNotes> Notes { get; set; }


        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseHeadTitle> CoursesHeads { get; set; }
        public DbSet<CourseTitle> CoursesTitles { get; set; }

    }
}
