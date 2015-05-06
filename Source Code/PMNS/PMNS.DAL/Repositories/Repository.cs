using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Linq.Expressions;
using PMNS.Entities.Models;

namespace PMNS.DAL.Repositories
{
    // TODO: Add more base functionality
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly WebNhanSuContext context;
        protected readonly DbSet<T> DbSet;

        public Repository(WebNhanSuContext context)
        {
            if (context != null)
            {
                this.context = context;
                this.DbSet = context.Set<T>();
            }
            else
            {
                throw new ArgumentNullException("DbContext");
            }
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet.AsQueryable();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
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

        public virtual void Insert(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Delete(object id)
        {
            T entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Update(T entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}