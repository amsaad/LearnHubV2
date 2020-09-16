using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Entities
{
    public class LKPath : BaseLK
    {
        public string CertName { get; set; }
        public string About { get; set; }
        public IEnumerable<HubCourses> Courses { get; set; }

    }
}
