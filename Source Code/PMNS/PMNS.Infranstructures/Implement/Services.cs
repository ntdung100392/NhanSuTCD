namespace PMNS.Infranstructures.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Reflection;

    using PMNS.DAL.Abstract;

    public abstract class Services<T> where T : class
    {
        #region Constructor Or Destructor

        protected readonly IUnitOfWork unitOfWork;

        public Services(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        #endregion

        #region Method

        public virtual DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
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

        #endregion
    }
}
