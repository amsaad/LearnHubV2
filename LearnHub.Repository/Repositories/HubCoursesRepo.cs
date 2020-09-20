using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class HubCoursesRepo : RepositoryBase<HubCourses>
    {
        public HubCoursesRepo():base(new LearnHubContext())
        {

        }
        public HubCoursesRepo(LearnHubContext context) : base(context)
        {

        }
    }
}
