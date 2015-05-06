using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PMNS.DAL.Repositories
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Delete(T entity);
        IQueryable<T> GetAll();
        void Delete(object id);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "");
        void Insert(T entity);
        void Update(T entityToUpdate);
    }
}