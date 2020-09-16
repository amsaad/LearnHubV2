using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKInstructorStore : RepositoryBase<LKInstructor>
    {
        public LKInstructorStore() : base(new LearnHubContext())
        {

        }
        public LKInstructorStore(LearnHubContext context) : base(context)
        {

        }

    }
}
