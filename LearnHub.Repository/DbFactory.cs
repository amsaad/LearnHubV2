using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class DbFactory : ILearnHubDbFactory
    {
        LearnHubEntities context;
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }

        public LearnHubEntities Init()
        {
            return context ?? (context = new LearnHubEntities());
        }
    }
}
