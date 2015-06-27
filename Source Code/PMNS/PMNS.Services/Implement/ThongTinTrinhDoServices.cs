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

    public class ThongTinTrinhDoServices : Services<ThongTinTrinhDo>, IThongTinTrinhDoServices
    {
        public ThongTinTrinhDoServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<ThongTinTrinhDo> GetThongTinTrinhDoByEmpId(int empId)
        {
            return unitOfWork.Repository<ThongTinTrinhDo>().GetAll().Where(x => x.idNhanVien == empId).ToList().
                OrderByDescending(x => x.thoiGianTotNghiep).ToList();
        }

        public List<ThongTinTrinhDo> GetAllThongTinTrinhDo()
        {
            return unitOfWork.Repository<ThongTinTrinhDo>().GetAll().OrderBy(x => x.ThongTinNhanVIen.MaNV).ToList();
        }

        public ThongTinTrinhDo GetThongTinTrinhDoById(int id)
        {
            return unitOfWork.Repository<ThongTinTrinhDo>().GetById(id);
        }

        public bool AddThongTinTrinhDo(ThongTinTrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                try
                {
                    unitOfWork.Repository<ThongTinTrinhDo>().Insert(trinhDo);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool UpdateThongTinTrinhDo(ThongTinTrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                try
                {
                    unitOfWork.Repository<ThongTinTrinhDo>().Update(trinhDo);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    throw e;
                }
            }
            else
            {
                return false;
            }
        }

        public bool DeleteThongTinTrinhDo(ThongTinTrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                try
                {
                    unitOfWork.Repository<ThongTinTrinhDo>().Delete(trinhDo);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidOperationException e)
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
