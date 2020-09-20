using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(int ID);
        T GetByUserID(string UID);
        T Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");


        Task<T> GetAsync(int ID);
        Task<T> GetByUserIDAsync(string UID);
        Task<T> GetAsync(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> where);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "");


        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Delete(int ID);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> condation);
        void DeleteRange(IEnumerable<T> entities);

        void Save();
        Task SaveAsync();
    }
}
