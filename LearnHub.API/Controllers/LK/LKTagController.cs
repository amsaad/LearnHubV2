using LearnHub.Entities;
using LearnHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LearnHub.API.Controllers
{
    public class LKTagController : ApiController
    {
        private LKTagStore _Store;
        private LKTagStore Store
        {
            get
            {
                return _Store ?? (_Store = new LKTagStore()); ;
            }
        }
        // GET: api/LkCategory
        public IEnumerable<LKTag> Get()
        {
            return Store.GetAll();
        }

        // GET: api/LkCategory/5
        public LKTag Get(int id)
        {
            return Store.Get(id);
        }

        // POST: api/LkCategory
        public void Post([FromBody] LKTag value)
        {
            Store.Add(value);
        }

        // PUT: api/LkCategory/5
        public void Put([FromBody] LKTag value)
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
