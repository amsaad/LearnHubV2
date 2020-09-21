using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class HubCoursesHeadTitlesRepo : RepositoryBase<HubCoursesHeadTitles>
    {
        public HubCoursesHeadTitlesRepo():base(new HubContext())
        {

        }
        public HubCoursesHeadTitlesRepo(HubContext context) : base(context)
        {

        }
    }
}
