using LearnHub.Entities;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKPathStore : RepositoryBase<LKPath>
    {
        
        public LKPathStore():base(new HubContext())
        {

        }
        public LKPathStore(HubContext context):base(context)
        {

        }
    }
}
