﻿using LearnHub.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearnHub.Repository
{
    public class LKCategoryStore : RepositoryBase<LKCategory>, IRepository<LKCategory>
    {
        public LKCategoryStore()
            : base() { }

        public override void Add(LKCategory entity)
        {
            base.Add(entity);
        }

        public override void Delete(int ID)
        {
            base.Delete(ID);
        }

        public override void Delete(Expression<Func<LKCategory, bool>> where)
        {
            base.Delete(where);
        }

        public override void Delete(LKCategory entity)
        {
            base.Delete(entity);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override LKCategory Get(int ID)
        {
            return base.Get(ID);
        }

        public override LKCategory Get(Expression<Func<LKCategory, bool>> where)
        {
            return base.Get(where);
        }

        public override IEnumerable<LKCategory> GetAll()
        {
            return base.GetAll();
        }

        public override IEnumerable<LKCategory> GetAll(Expression<Func<LKCategory, bool>> where)
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

        public override void Update(LKCategory entity)
        {
            base.Update(entity);
        }
    }
}