using LearnHub.Entities;
using LearnHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace LearnHub.API.Controllers
{
    public class LkCategoryController : ApiController
    {
        private LKCategoryStore _Store;
        private LKCategoryStore Store
        {
            get
            {
                return _Store ?? (_Store = new LKCategoryStore()); ;
            }
        }
        // GET: api/LkCategory
        public HttpResponseMessage Get()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK,
                Store.GetAll().ToList());
            return response;
        }

        // GET: api/LkCategory/5
        public LKCategory Get(int id)
        {
            return Store.Get(id);
        }

        // POST: api/LkCategory
        public void Post([FromBody] LKCategory value)
        {
            Store.Add(value);
        }

        // PUT: api/LkCategory/5
        public void Put([FromBody] LKCategory value)
        {
            Store.Update(value);
        }

        // DELETE: api/LkCategory/5
        public void Delete(int id)
        {
            Store.Delete(id);
        }

    }
}
