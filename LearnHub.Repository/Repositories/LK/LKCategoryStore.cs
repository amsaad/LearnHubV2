using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKCategoryStore : RepositoryBase<LKCategory>
    {
        public LKCategoryStore() : base(new HubContext())
        {

        }
        public LKCategoryStore(HubContext context) : base(context)
        {
        }
    }
}
