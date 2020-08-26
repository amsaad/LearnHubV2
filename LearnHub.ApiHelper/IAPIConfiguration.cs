using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.ApiHelper
{
    public interface IAPIConfiguration<T>
    {
        Task<bool> Add(T entity);
        bool Update(T entity);
        Task<List<T>> List();
        Task<bool> Remove(int ID);
    }
}
