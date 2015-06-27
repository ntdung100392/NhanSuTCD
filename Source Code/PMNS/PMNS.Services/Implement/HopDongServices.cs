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
    using PMNS.Infranstructures.Implement;

    public class HopDongServices : Services<HopDongLaoDong>, IHopDongServices
    {
        public HopDongServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<HopDongLaoDong> GetAllHopDong()
        {
            return unitOfWork.Repository<HopDongLaoDong>().GetAll().ToList()
                .OrderByDescending(x => x.ngayBatDau).ToList();
        }

        public List<HopDongLaoDong> GetHopDongByEmpId(int id)
        {
            return unitOfWork.Repository<HopDongLaoDong>().Get().Where(x => x.idNhanVien == id)
                .ToList().OrderByDescending(x => x.ngayBatDau).ToList();
        }

        public HopDongLaoDong GetHopDongById(int id)
        {
            return unitOfWork.Repository<HopDongLaoDong>().GetById(id);
        }

        public bool AddHopDongLaoDong(HopDongLaoDong hopDong)
        {
            if (hopDong != null)
            {
                try
                {
                    unitOfWork.Repository<HopDongLaoDong>().Insert(hopDong);
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

        public bool UpdateHopDongLaoDong(HopDongLaoDong hopDong)
        {
            if (hopDong != null)
            {
                try
                {
                    unitOfWork.Repository<HopDongLaoDong>().Update(hopDong);
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
    }
}
