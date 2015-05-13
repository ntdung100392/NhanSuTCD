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

        public string AddThongTinGiaDinh(ThongTinGiaDinh info)
        {
            if (info != null)
            {
                if (unitOfWork.Repository<ThongTinNhanVIen>().GetById(info.idNhanVien) != null)
                {
                    unitOfWork.Repository<ThongTinGiaDinh>().Insert(info);
                    unitOfWork.Commit();
                    return "Thêm Thông Tin Gia Đình Thành Công!";
                }
                return "Không Tồn Tại Nhân Viên Trên Trong Cơ Sở Dữ Liệu!";
            }
            return "Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!";
        }

        public string UpdateThongTinGiaDinh(ThongTinGiaDinh info)
        {
            if (info != null)
            {
                if (unitOfWork.Repository<ThongTinNhanVIen>().GetById(info.idNhanVien) != null)
                {
                    try
                    {
                        unitOfWork.Repository<ThongTinGiaDinh>().Update(info);
                        unitOfWork.Commit();
                        return "Đã Chỉnh Sửa Thành Công!";
                    }
                    catch (InvalidOperationException e)
                    {
                        throw e;
                    }
                }
                return "Không Tồn Tại Nhân Viên Trên Trong Cơ Sở Dữ Liệu!";
            }
            return "Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin!";
        }
    }
}
