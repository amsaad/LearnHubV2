using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.ApiHelper
{
    public interface IAPIConfiguration<T>
    {
        Task<HttpResponseMessage> AddAsync(T entity);
        bool Update(T entity);
        Task<HttpResponseMessage> ListAsync();
        Task<bool> Remove(int ID);
    }
}
