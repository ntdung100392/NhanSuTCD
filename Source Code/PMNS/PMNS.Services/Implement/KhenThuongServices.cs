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
    public class KhenThuongServices : Services<KhenThuong>, IKhenThuongServices
    {
        public KhenThuongServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<KhenThuong> GetAllKhenThuong()
        {
            return unitOfWork.Repository<KhenThuong>().GetAll().ToList();
        }

        public KhenThuong GetKhenThuongById(int id)
        {
            return unitOfWork.Repository<KhenThuong>().GetById(id);
        }

        public bool AddThongTinKhenThuong(KhenThuong khenThuong)
        {
            if (khenThuong != null)
            {
                try
                {
                    unitOfWork.Repository<KhenThuong>().Insert(khenThuong);
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

        public bool UpdateThongTinKhenThuong(KhenThuong khenThuong)
        {
            if (khenThuong != null)
            {
                try
                {
                    unitOfWork.Repository<KhenThuong>().Update(khenThuong);
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
