using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;
using PMNS.Services.Abstract;

namespace PMNS.Services.Implement
{
    public class ThongTinTrinhDoServices : Services<TrinhDo>, IThongTinTrinhDoServices
    {
        public ThongTinTrinhDoServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<TrinhDo> GetThongTinTrinhDoByEmpId(int empId)
        {
            return unitOfWork.Repository<TrinhDo>().GetAll().Where(x => x.idNhanVien == empId).ToList().
                OrderByDescending(x => x.thoiGianTotNghiep).ToList();
        }

        public bool AddThongTinTrinhDo(TrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                try
                {
                    unitOfWork.Repository<TrinhDo>().Insert(trinhDo);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidCastException e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateThongTinTrinhDo(TrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                try
                {
                    unitOfWork.Repository<TrinhDo>().Update(trinhDo);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidCastException e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteThongTinTrinhDo(TrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                try
                {
                    unitOfWork.Repository<TrinhDo>().Delete(trinhDo);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidCastException e)
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
