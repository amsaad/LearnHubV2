using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.ApiHelper.Utility
{
    class ApiHelper
    {
        public static HttpClient ApiClient;
        private static string APIUrl => ConfigurationManager.AppSettings["APIUrl"];
        public ApiHelper()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.BaseAddress = new Uri(APIUrl);
        }

        public static async Task<HttpContent> Get(string Controller, string Action, bool allowAnonymous = true, params object[] inputs)
        {

            return null;
        }
    }
}
