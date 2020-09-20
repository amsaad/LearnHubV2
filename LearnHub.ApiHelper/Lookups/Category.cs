using LearnHub.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.ApiHelper.Lookups
{
    public class Category : APIConfiguration<LKCategory>, IAPIConfiguration<LKCategory>
    {
        //public static Category _category { get { return new Category(); } }
        //public Category() : base()
        //{
        //    EntityUrl = nameof(LKCategory);
        //}

        //public async Task<bool> Add(LKCategory entity)
        //{
        //    var response = await base.Post(entity);
        //    Task<string> result = response.Content.ReadAsStringAsync();
        //    if (string.IsNullOrEmpty(result.Result))
        //        return false;
        //    return true;
        //}

        //public async Task<bool> Remove(int ID)
        //{
        //    var response = await base.Delete(ID);
        //    Task<string> result = response.Content.ReadAsStringAsync();
        //    if (string.IsNullOrEmpty(result.Result))
        //        return false;
        //    return true;
        //}

        //public async Task<List<LKCategory>> List()
        //{
        //    var response = await base.ListItems();
        //    if (response.StatusCode != HttpStatusCode.OK)
        //    {
        //        throw new Exception("Log");
        //    }
        //    var result = response.Content.ReadAsStringAsync().Result;
        //    List<LKCategory> lst = JsonConvert.DeserializeObject<List<LKCategory>>(result);
        //    return lst;
        //}

        //public bool Update(LKCategory entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
