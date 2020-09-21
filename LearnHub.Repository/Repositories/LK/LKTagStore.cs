using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKTagStore : RepositoryBase<LKTag>
    {
        public LKTagStore():base(new HubContext())
        {

        }
        public LKTagStore(HubContext context):base(context)
        {

        }
    }
}
