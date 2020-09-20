using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class HubCoursesTitlesRepo : RepositoryBase<HubCoursesTitles>
    {
        public HubCoursesTitlesRepo():base(new LearnHubContext())
        {

        }
        public HubCoursesTitlesRepo(LearnHubContext context) : base(context)
        {

        }
    }
}
