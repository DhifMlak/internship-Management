using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace InternshipManagement.Data.Infrastructures
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {//new()

        private InternshipManagementAPIContext dataContext;
        private readonly IDbSet<T> dbset; // générique

        public RepositoryBase(InternshipManagementAPIContext dataContext)
        {
            this.dataContext = dataContext;
            dbset = dataContext.Set<T>();// set ; remplit la variable dbset avec T

        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified; // etat de la variable
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> condition) // expression : strongly tiped lambda expression
        {
            IEnumerable<T> objects = dbset.Where<T>(condition).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        //public virtual IEnumerable<T> GetAll()
        //{
        //    return dbset.ToList();
        //}

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null,
            Expression<Func<T, bool>> orderBy = null)
        {
            IEnumerable<T> Query1 = dbset;
            IQueryable<T> Query = dbset;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            if (orderBy != null)
            {
                Query = Query.OrderBy(orderBy);
            }
            if (where != null)
                return dbset.Where(where).AsEnumerable();
            return Query1.AsEnumerable();
        }
        public T Get(Expression<Func<T, bool>> where = null)
        {
            //if (dbset.Where(where).Count() > 0)
            //    return dbset.Where(where).FirstOrDefault<T>();
            return dbset.Where(where).AsEnumerable().First<T>();
        }


    }
}
