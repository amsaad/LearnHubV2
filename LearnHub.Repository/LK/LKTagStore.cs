using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKTagStore : RepositoryBase<LKTag>, IRepository<LKTag>
    {
        public LKTagStore()
            : base() { }

        public override void Add(LKTag entity)
        {
            base.Add(entity);
        }

        public override void Delete(int ID)
        {
            base.Delete(ID);
        }

        public override void Delete(Expression<Func<LKTag, bool>> where)
        {
            base.Delete(where);
        }

        public override void Delete(LKTag entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override LKTag Get(int ID)
        {
            return base.Get(ID);
        }

        public override LKTag Get(Expression<Func<LKTag, bool>> where)
        {
            return base.Get(where);
        }

        public override IEnumerable<LKTag> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<LKTag> GetAll(Expression<Func<LKTag, bool>> where)
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

        public override void Update(LKTag entity)
        {
            base.Update(entity);
        }
    }
}
