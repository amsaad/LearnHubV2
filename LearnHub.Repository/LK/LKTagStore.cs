using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKTagStore : RepositoryBase<LKTag>, IRepository<LKTag>
    {
        public LKTagStore():base(new LearnHubContext())
        {

        }
        public LKTagStore(LearnHubContext context):base(context)
        {

        }
    }
}
