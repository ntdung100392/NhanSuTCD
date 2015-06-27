namespace PMNS.Services.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.DAL.Abstract;
    using PMNS.Services.Abstract;
    using PMNS.Infrastructures.Implement;

    public class KyLuatServices : Services<KyLuat>, IKyLuatServices
    {
        public KyLuatServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<KyLuat> GetAllKyLuat()
        {
            return unitOfWork.Repository<KyLuat>().GetAll().ToList();
        }

        public KyLuat GetKyLuatById(int id)
        {
            return unitOfWork.Repository<KyLuat>().GetById(id);
        }

        public bool AddThongTinKyLuat(KyLuat kyLuat)
        {
            if (kyLuat != null)
            {
                try
                {
                    unitOfWork.Repository<KyLuat>().Insert(kyLuat);
                    unitOfWork.Commit();
                    return true;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateThongTinKyLuat(KyLuat kyLuat)
        {
            if (kyLuat != null)
            {
                try
                {
                    unitOfWork.Repository<KyLuat>().Update(kyLuat);
                    unitOfWork.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
