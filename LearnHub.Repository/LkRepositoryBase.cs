using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LearnHub.Repository
{
    public class LkRepositoryBase<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<T, bool>> condation)
        {
            throw new NotImplementedException();
        }

        public T Get(int ID)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}