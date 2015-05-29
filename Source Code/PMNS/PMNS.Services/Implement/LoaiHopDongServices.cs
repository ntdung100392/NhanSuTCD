using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;

namespace PMNS.Services.Implement
{
    public class LoaiHopDongServices : Services<LoaiHopDong>, ILoaiHopDongServices
    {
        public LoaiHopDongServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<LoaiHopDong> GettAllLoaiHopDong()
        {
            return unitOfWork.Repository<LoaiHopDong>().GetAll().OrderBy(x => x.loaiHopDong1).ToList();
        }

        public bool AddLoaiHopDong(LoaiHopDong loaiHopDong)
        {
            if (loaiHopDong != null)
            {
                try
                {
                    unitOfWork.Repository<LoaiHopDong>().Insert(loaiHopDong);
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

        public bool UpdateLoaiHopDong(LoaiHopDong loaiHopDong)
        {
            if (loaiHopDong != null)
            {
                try
                {
                    unitOfWork.Repository<LoaiHopDong>().Update(loaiHopDong);
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
