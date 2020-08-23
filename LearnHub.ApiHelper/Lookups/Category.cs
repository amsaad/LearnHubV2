using LearnHub.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.ApiHelper.Lookups
{
    public class Category : APIConfiguration<LKCategory>, IAPIConfiguration<LKCategory>
    {
        public Category() : base()
        {
            EntityUrl = nameof(LKCategory);
        }

        public async Task<bool> Add(LKCategory entity)
        {
            var response = await base.Post(entity);
            Task<string> result = response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(result.Result))
                return false;
            return true;
        }

        public async Task<bool> Remove(int ID)
        {
            var response = await base.Delete(ID);
            Task<string> result = response.Content.ReadAsStringAsync();
            if (string.IsNullOrEmpty(result.Result))
                return false;
            return true;
        }

        public async Task<IEnumerable<LKCategory>> GetAsync()
        {
            var response = await base.ListItems();
            var _t = response.Content.ReadAsStringAsync();
            IEnumerable<LKCategory> result = JsonConvert.DeserializeObject<IEnumerable<LKCategory>>(_t.Result);
            return result;
        }

        public bool Update(LKCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
