namespace PMNS.Services.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Services.Abstract;
    using PMNS.Entities.Models;
    using PMNS.DAL.Abstract;
    using PMNS.Infrastructures.Implement;

    public class TrinhDoServices : Services<TrinhDo>, ITrinhDoServices
    {
        public TrinhDoServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<TrinhDo> GetAllTrinhDo()
        {
            return unitOfWork.Repository<TrinhDo>().GetAll().ToList();
        }

        public TrinhDo GetTrinhDoById(int id)
        {
            return unitOfWork.Repository<TrinhDo>().GetById(id);
        }

        public bool AddTrinhDo(TrinhDo trinhDo)
        {
            try
            {
                unitOfWork.Repository<TrinhDo>().Insert(trinhDo);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateTrinhDo(TrinhDo trinhDo)
        {
            try
            {
                unitOfWork.Repository<TrinhDo>().Update(trinhDo);
                unitOfWork.Commit();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
