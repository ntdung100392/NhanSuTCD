using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;

namespace PMNS.Services.Implement
{
    public abstract class Service<T> : IService<T> where T : class
    {
        protected readonly IUnitOfWork unitOfWork;

        public Service(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public virtual IEnumerable<T> Get(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = "")
        {
            return unitOfWork.Repository<T>().Get(filter, orderBy, includeProperties);
        }

        public virtual T GetById(int id)
        {
            return unitOfWork.Repository<T>().GetById(id);
        }

        public virtual void Insert(T entity)
        {
            unitOfWork.Repository<T>().Insert(entity);
        }

        public virtual void Delete(object id)
        {
            unitOfWork.Repository<T>().Delete(id);
        }

        public virtual void Delete(T entityToDelete)
        {
            unitOfWork.Repository<T>().Delete(entityToDelete);
        }

        public virtual void Update(T entityToUpdate)
        {
            unitOfWork.Repository<T>().Update(entityToUpdate);
        }
    }
}
