using LearnHub.API.Helpers;
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
    public class LKInstructorController : APIBase
    {
        private IRepository<LKInstructor> Store;
        
        // GET: api/LKInstructor
        public IEnumerable<LKInstructor> Get()
        {
            return Store.GetAll();
        }

        // GET: api/LKInstructor/5
        public LKInstructor Get(int id)
        {
            return Store.Get(id);
        }

        // POST: api/LKInstructor
        public void Post([FromBody] LKInstructor value)
        {
            Store.Add(value);
        }

        // PUT: api/LKInstructor/5
        public void Put([FromBody] LKInstructor value)
        {
            Store.Update(value);
        }

        // DELETE: api/LKInstructor/5
        public void Delete(int id)
        {
            Store.Delete(id);
        }

    }
}
