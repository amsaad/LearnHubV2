using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class UserCourseRequestRepo : RepositoryBase<UserCourseRequest>
    {
        public UserCourseRequestRepo():base(new HubContext())
        {

        }
        public UserCourseRequestRepo(HubContext context) : base(context)
        {

        }
    }
}
