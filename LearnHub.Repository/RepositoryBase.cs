using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private LearnHubEntities dataContext;
        private readonly DbSet<T> dbSet;

        protected ILearnHubDbFactory DbFactory
        {
            get;
            private set;
        }

        protected LearnHubEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        protected RepositoryBase(ILearnHubDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
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

            return dbSet.AsEnumerable();
        }
        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {

            return dbSet.Where(where).ToList();
        }
        public virtual void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Action::Add - Message::No entity provided");
            }
            dbSet.Add(entity);
            DbContext.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Action::Update - Message::No entity provided");
            }
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
        public virtual void Delete(int ID)
        {
            if (ID >= 0)
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

            DbContext.SaveChanges();
        }
        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Action::Delete - Message::No entity provided");
            }
            dbSet.Remove(entity);
            DbContext.SaveChanges();
        }
        public virtual Save(){
DbContext.SaveChanges();
        }
    }
}
