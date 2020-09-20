using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace LearnHub.Filters
{
    public class AllowOnlyAttribute : AuthorizeAttribute
    {
        public AllowOnlyAttribute(params SystemRoles[] roles) : base()
        {
            Roles = String.Join(",", Enum.GetNames(typeof(SystemRoles)));
        }
    }
}