using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : BaseEntity
    {
        internal LearnHubContext context;
        internal DbSet<T> dbSet;
        protected LearnHubContext DbContext
        {
            get { return context ?? (context = new LearnHubContext()); }
        }
        protected RepositoryBase()
        {
            dbSet = DbContext.Set<T>();
        }
        protected RepositoryBase(LearnHubContext _context)
        {
            context = _context;
            dbSet = _context.Set<T>();
        }




        #region Get
        public T GetByUserID(string UID)
        {
            return dbSet.Where(c => c.UserID == UID).FirstOrDefault();
        }
        public virtual T Get(int ID)
        {
            return dbSet.Find(ID);
        }
        public virtual T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }
        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> expression, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            IQueryable<T> query = dbSet;

            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }


            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        #endregion

        #region Add Update
        public virtual void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Action::Add - Message::No entity provided");
            }
            dbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Action::Update - Message::No entity provided");
            }
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }
        #endregion

        #region Delete
        public virtual void Delete(int ID)
        {
            if (ID <= 0)
            {
                throw new ArgumentNullException("Action::Delete - Message::No ID provided");
            }
            dbSet.Remove(dbSet.Find(ID));
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            if (objects == null || objects.Count() <= 0)
            {
                throw new ArgumentNullException("Action::Delete - Message::No matching items");
            }
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Action::Delete - Message::No entity provided");
            }
            if (context.Entry(entity).State == EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);
        }

        #endregion

        public virtual void Save()
        {
            DbContext.SaveChanges();
        }


    }
}
