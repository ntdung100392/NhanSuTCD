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
    public class ThongTinGiaDinhServices : Services<ThongTinGiaDinh>, IThongTinGiaDinhServices
    {
        public ThongTinGiaDinhServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public ThongTinGiaDinh GetThongTinByNhanVienId(int id)
        {
            return unitOfWork.Repository<ThongTinGiaDinh>().Get().Where(x => x.idNhanVien == id).FirstOrDefault();
        }

        public bool AddThongTinGiaDinh(ThongTinGiaDinh info)
        {
            if (info != null)
            {
                if (unitOfWork.Repository<ThongTinNhanVIen>().GetById(info.idNhanVien) != null)
                {
                    unitOfWork.Repository<ThongTinGiaDinh>().Insert(info);
                    unitOfWork.Commit();
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool UpdateThongTinGiaDinh(ThongTinGiaDinh info)
        {
            if (info != null)
            {
                if (unitOfWork.Repository<ThongTinNhanVIen>().GetById(info.idNhanVien) != null)
                {
                    try
                    {
                        unitOfWork.Repository<ThongTinGiaDinh>().Update(info);
                        unitOfWork.Commit();
                        return true;
                    }
                    catch (InvalidOperationException e)
                    {
                        throw e;
                    }
                }
                return false;
            }
            return false;
        }
    }
}
