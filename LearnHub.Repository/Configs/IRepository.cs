using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int ID);
        T GetByUserID(string UID);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");
        void Add(T entity);
        void Update(T entity);
        void Delete(int ID);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> condation);
        void Save();
    }
}
