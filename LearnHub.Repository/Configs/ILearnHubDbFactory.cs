using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public interface ILearnHubDbFactory : IDisposable
    {
        LearnHubEntities Init();
    }
}
