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
    public class CapBacServices : Services<CapBac>, ICapBacServices
    {
        public CapBacServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<CapBac> GetAllCapBac()
        {
            List<CapBac> listCapBac = unitOfWork.Repository<CapBac>().GetAll().ToList();
            return listCapBac;
        }

        public bool AddCapBac(CapBac capBac)
        {
            if (capBac != null)
            {
                try
                {
                    unitOfWork.Repository<CapBac>().Insert(capBac);
                    unitOfWork.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }            
            return false;
        }

        public bool UpdateCapBac(CapBac capBacUpdate)
        {
            if (capBacUpdate != null)
            {
                try
                {
                    unitOfWork.Repository<CapBac>().Update(capBacUpdate);
                    unitOfWork.Commit();
                    return true;
                }
                catch(Exception e)
                {
                    throw e;
                }
            }
            return false;
        }

        public string DeleteCapBac(CapBac capBacDelete)
        {
            if (capBacDelete != null)
            {
                if (capBacDelete.ThongTinNhanVIens.ToList() != null)
                {
                    try
                    {
                        unitOfWork.Repository<CapBac>().Delete(capBacDelete);
                        unitOfWork.Commit();
                        return "Cấp Bậc Đã Được Xóa!";
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                }
                else
                {
                    return "Vẫn Còn Nhân Viên Sử Dụng Cấp Bậc Này! Không Thể Xóa!";
                }
            }
            return "Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin!";
        }
    }
}
