using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LearnHubEntities : DbContext
    {
        public LearnHubEntities() : base("LearnHubDB") { }
    }
}
