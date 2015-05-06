using System;
using PMNS.DAL.Repositories;

namespace PMNS.DAL.Abstract
{
    /// <summary>
    /// Unit of work provides access to repositories.  Operations on multiple repositories are atomic through
    /// the use of Commit().
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;
        void Commit();
    }
}