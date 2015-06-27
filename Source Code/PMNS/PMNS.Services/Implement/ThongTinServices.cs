namespace PMNS.Services.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;
    using PMNS.DAL.Abstract;
    using PMNS.Infrastructures.Implement;

    public class ThongTinServices : Services<TD_DD_BN_TV>, IThongTinServices
    {
        public ThongTinServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<TD_DD_BN_TV> GetAllThongTin()
        {
            return unitOfWork.Repository<TD_DD_BN_TV>().GetAll().OrderByDescending(x => x.ngayKyQD).ToList();
        }

        public List<TD_DD_BN_TV> GetThongTinByEmpId(int empId)
        {
            return unitOfWork.Repository<TD_DD_BN_TV>().Get().Where(x => x.idNhanVien == empId).ToList();
        }

        public TD_DD_BN_TV GetThongTinById(int id)
        {
            return unitOfWork.Repository<TD_DD_BN_TV>().GetById(id);
        }

        public bool AddThongTin(TD_DD_BN_TV thongTin)
        {
            if (thongTin != null)
            {
                try
                {
                    unitOfWork.Repository<TD_DD_BN_TV>().Insert(thongTin);
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

        public bool UpdateThongTin(TD_DD_BN_TV thongTin)
        {
            if (thongTin != null)
            {
                try
                {
                    unitOfWork.Repository<TD_DD_BN_TV>().Update(thongTin);
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

        public List<TD_DD_BN_TV> FindThongTin(string condition)
        {
            return unitOfWork.Repository<TD_DD_BN_TV>().GetAll().Where(x => x.ThongTinNhanVIen.MaNV.Contains(condition)).ToList();
        }
    }
}
