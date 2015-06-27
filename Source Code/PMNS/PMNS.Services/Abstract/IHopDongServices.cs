namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.DAL.Abstract;
    using PMNS.Entities.Models;

    public interface IHopDongServices
    {
        List<HopDongLaoDong> GetAllHopDong();
        List<HopDongLaoDong> GetHopDongByEmpId(int id);
        HopDongLaoDong GetHopDongById(int id);
        bool AddHopDongLaoDong(HopDongLaoDong hopDong);
        bool UpdateHopDongLaoDong(HopDongLaoDong hopDong);
    }
}
