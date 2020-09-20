using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Entities
{
    public class AppSettings : BaseEntity
    {
        public bool IsRegistrationOpen { get; set; } = true;
        public bool IsRegistrationRequiredApproval { get; set; }

    }
}
