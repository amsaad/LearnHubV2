using LearnHub.Entities;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKPathStore : RepositoryBase<LKPath>, IRepository<LKPath>
    {

        public LKPathStore()
            : base() { }

        public override void Add(LKPath entity)
        {
            base.Add(entity);
        }

        public override void Delete(int ID)
        {
            base.Delete(ID);
        }

        public override void Delete(Expression<Func<LKPath, bool>> where)
        {
            base.Delete(where);
        }

        public override void Delete(LKPath entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override LKPath Get(int ID)
        {
            return base.Get(ID);
        }

        public override LKPath Get(Expression<Func<LKPath, bool>> where)
        {
            return base.Get(where);
        }

        public override IEnumerable<LKPath> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<LKPath> GetAll(Expression<Func<LKPath, bool>> where)
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

        public override void Update(LKPath entity)
        {
            base.Update(entity);
        }
    }
}
