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
            ThongTinGiaDinh info = unitOfWork.Repository<ThongTinGiaDinh>().GetById(id);
            return info;
        }

        public bool DeleteThongTinByNhanVienId(int id)
        {
            ThongTinGiaDinh info = unitOfWork.Repository<ThongTinGiaDinh>().GetById(id);
            if (info != null)
            {
                try
                {
                    unitOfWork.Repository<ThongTinGiaDinh>().Delete(info);
                    unitOfWork.Commit();
                    return true;
                }
                catch(InvalidOperationException e)
                {
                    throw e;
                }
            }
            return false;
        }
    }
}
