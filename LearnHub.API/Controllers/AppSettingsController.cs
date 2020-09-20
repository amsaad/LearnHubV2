using LearnHub.API.Helpers;
using LearnHub.Entities;
using LearnHub.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LearnHub.API.Controllers
{
    public class AppSettingsController : APIBase
    {
        private IRepository<AppSettings> repo;

        public AppSettingsController()
        {
            repo = new AppSettingsRepo();
        }
        // GET api/<controller>
        public async Task<AppSettings> GetAsync()
        {
            var result = await repo.GetAllAsync();
            return result?.FirstOrDefault();

        }

        // POST api/<controller>
        public void Post([FromBody] AppSettings entity)
        {
            repo.Add(entity);
            repo.SaveAsync();
        }

        // PUT api/<controller>/5
        public void Put([FromBody] AppSettings entity)
        {
            repo.Update(entity);
            repo.SaveAsync();
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            repo.Delete(id);
            repo.SaveAsync();
        }
    }
}