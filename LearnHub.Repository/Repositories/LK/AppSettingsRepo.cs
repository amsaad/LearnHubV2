﻿using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class AppSettingsRepo : RepositoryBase<AppSettings>
    {
        public AppSettingsRepo():base(new HubContext())
        {

        }
        public AppSettingsRepo(HubContext context):base(context)
        {

        }
    }
}
