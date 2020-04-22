﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Data.Infrastructure
{
    class RepositoryBase<T> where T: class
    {
        private SMSDbContext smsDbContext;
        private readonly IDbSet<T> dbSet;
        /// <summary>
        /// khởi tạo đới tưởng model qua lớp FBfactory
        /// </summary>
        protected DbFactory DbFactory
        {
            get;
            private set;
        }
        /// <summary>
        /// Phương thức khởi tạo lớp DBContext
        /// </summary>
        protected SMSDbContext DbContext
        {
            get
            {
                // nếu chưa khởi tạo lớp 
                return smsDbContext ?? (smsDbContext = DbFactory.Init());
            }
        }


        protected RepositoryBase(DbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbSet = DbContext.Set<T>();
        }


        public virtual T Add(T entity)
        {
            try
            {
                return dbSet.Add(entity);

            }
            catch (Exception e)
            {

                throw e;
            }

        }
        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            smsDbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual T Delete(T entity)
        {
            return dbSet.Remove(entity);
        }

        public virtual T Delete(int id)
        {
            var entity = dbSet.Find(id);
            return dbSet.Remove(entity);
        }

        public virtual void DeleteMulti(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
            {
                dbSet.Remove(obj);
            }
        }

        public IEnumerable<T> GetAll(string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = smsDbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.AsQueryable();
            }
            return smsDbContext.Set<T>().AsQueryable();
        }


        public virtual IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null)
        {
            //HANDLE INCLUDES FOR ASSOCIATED OBJECTS IF APPLICABLE
            if (includes != null && includes.Count() > 0)
            {
                var query = smsDbContext.Set<T>().Include(includes.First());
                foreach (var include in includes.Skip(1))
                    query = query.Include(include);
                return query.Where<T>(predicate).AsQueryable<T>();
            }
            return smsDbContext.Set<T>().Where<T>(predicate).AsQueryable<T>();
        }

        public bool CheckContains(Expression<Func<T, bool>> predicate)
        {
            return smsDbContext.Set<T>().Count<T>(predicate) > 0;
        }


    }
}
