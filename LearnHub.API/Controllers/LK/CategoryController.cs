using LearnHub.API.Helpers;
using LearnHub.Entities;
using LearnHub.Filters;
using LearnHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace LearnHub.API.Controllers
{
    [AllowOnly(roles: SystemRoles.Admin | SystemRoles.SuperUser)]
    public class CategoryController : APIBase
    {
        private IRepository<LKCategory> Store;


        public CategoryController()
        {
            Store = new LKCategoryStore();
        }
        // GET: api/LkCategory

        [AllowAnonymous]
        public async Task<HttpResponseMessage> GetAsync()
        {
            IEnumerable<LKCategory> categories = await Store.GetAllAsync();
            if (categories == null || categories.Count() == 0)
                categories = new List<LKCategory>();

            return CreateResponse(HttpStatusCode.OK, categories);
        }

        // GET: api/LkCategory/5
        [Authorize]
        public async Task<HttpResponseMessage> GetAsync(int id)
        {
            LKCategory cat = await Store.GetAsync(id);
            return CreateResponse(HttpStatusCode.OK, cat);
        }

        // POST: api/LkCategory
        public async Task<HttpResponseMessage> PostAsync([FromBody] LKCategory value)
        {
            Store.Add(value);
            await Store.SaveAsync();
            return CreateResponse(HttpStatusCode.OK, value.ID);
        }

        // PUT: api/LkCategory/5
        public async Task<HttpResponseMessage> PutAsync([FromBody] LKCategory value)
        {
            Store.Update(value);
            await Store.SaveAsync();
            return CreateResponse(HttpStatusCode.OK, value.ID);
        }

        // DELETE: api/LkCategory/5
        public async Task<HttpResponseMessage> DeleteAsync(int id)
        {
            Store.Delete(id);
            await Store.SaveAsync();
            return CreateResponse(HttpStatusCode.OK, id);
        }

    }
}
