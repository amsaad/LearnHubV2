using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace LearnHub.ApiHelper
{
    public class APIConfiguration<T>
    {
        public static HttpClient ApiClient;
        public string EntityUrl;

        private static string APIUrl => ConfigurationManager.AppSettings["APIUrl"];
        public APIConfiguration()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.BaseAddress = new Uri(APIUrl);

            // Handle security
        }

        protected async Task<HttpResponseMessage> Post(T inputs)
        {
            return await ApiClient.PostAsync(ActionURL("Add"), JsonParams(inputs));

        }

        internal async Task<HttpResponseMessage> Delete(int iD)
        {
            return await ApiClient.DeleteAsync(ActionURL("DELETE") + "/" + iD.ToString());
        }

        public StringContent JsonParams(object inputs)
        {
            var json = JsonConvert.SerializeObject(inputs);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            return data;
        }

        internal async Task<HttpResponseMessage> ListItems()
        {
            try
            {
                LogProxy.LogEx("error here", nameof(ListItems));
                return await ApiClient.GetAsync(ActionURL(nameof(ListItems)));
            }
            catch (Exception ex)
            {
                LogProxy.LogEx("error here", ex);
                return null;
            }
        }

        public string ActionURL(string action)
        {
            return "API/" + EntityUrl; //+ "/" + action;
        }
    }
}
