using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;
using PMNS.DAL.Repositories;

namespace PMNS.DAL.Implement
{
    /// <summary>
    /// Unit of work provides access to repositories.  Operations on multiple repositories are atomic through
    /// the use of Commit().
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private WebNhanSuContext context;

        public UnitOfWork()
        {
            context = new WebNhanSuContext();
        }

        public IRepository<T> Repository<T>() where T : class
        {
            return new Repository<T>(context);
        }

        /// <summary>
        /// Commits changes made to all repositories
        /// </summary>
        public void Commit()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
