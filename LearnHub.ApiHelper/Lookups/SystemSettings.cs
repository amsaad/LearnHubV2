using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.ApiHelper
{
    public class SystemSettings : APIConfiguration<AppSettings>
    {
        public SystemSettings()
        {
            EntityUrl = nameof(AppSettings);
        }
    }
}
