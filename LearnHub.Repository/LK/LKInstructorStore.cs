using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKInstructorStore : RepositoryBase<LKInstructor>, IRepository<LKInstructor>
    {
        public LKInstructorStore()
            : base() { }

        public override void Add(LKInstructor entity)
        {
            base.Add(entity);
        }

        public override void Delete(int ID)
        {
            base.Delete(ID);
        }

        public override void Delete(Expression<Func<LKInstructor, bool>> where)
        {
            base.Delete(where);
        }

        public override void Delete(LKInstructor entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override LKInstructor Get(int ID)
        {
            return base.Get(ID);
        }

        public override LKInstructor Get(Expression<Func<LKInstructor, bool>> where)
        {
            return base.Get(where);
        }

        public override IEnumerable<LKInstructor> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<LKInstructor> GetAll(Expression<Func<LKInstructor, bool>> where)
        {
            return base.GetAll(where);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override void Save()
        {
            base.Save();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void Update(LKInstructor entity)
        {
            base.Update(entity);
        }
    }
}
