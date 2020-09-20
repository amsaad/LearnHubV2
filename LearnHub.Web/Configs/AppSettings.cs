using LearnHub.ApiHelper;
using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace LearnHub.Web.Configs
{
    public class SysSettings
    {
        [OutputCache(Duration = 3600)]
        public async Task<AppSettings> GetSettings()
        {
            SystemSettings sys = new SystemSettings();
            HttpResponseMessage response = await sys.ListAsync();
            if (response.IsSuccessStatusCode)
            { 
            
            }
            return await Task.FromResult(new AppSettings());
        }
    }
}