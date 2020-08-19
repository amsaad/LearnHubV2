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
    public class LKPathController : ApiController
    {
        private LKPathStore _store;
        private LKPathStore Store
        {
            get
            {
                return _store ?? (_store = new LKPathStore()); ;
            }
        }
        // GET: api/LKPath
        public IEnumerable<LKPath> Get()
        {
            return Store.GetAll();
        }

        // GET: api/LKPath/5
        public LKPath Get(int id)
        {
            return Store.Get(id);
        }

        // POST: api/LKPath
        public void Post([FromBody] LKPath value)
        {
            Store.Add(value);
        }

        // PUT: api/LKPath/5
        public void Put([FromBody] LKPath value)
        {
            Store.Update(value);
        }

        // DELETE: api/LKPath/5
        public void Delete(int id)
        {
            Store.Delete(id);
        }

    }
}
