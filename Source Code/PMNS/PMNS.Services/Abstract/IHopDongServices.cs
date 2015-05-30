using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IHopDongServices : IServices<HopDongLaoDong>
    {
        List<HopDongLaoDong> GetAllHopDong();
        List<HopDongLaoDong> GetHopDongByEmpId(int id);
        HopDongLaoDong GetHopDongById(int id);
        bool AddHopDongLaoDong(HopDongLaoDong hopDong);
        bool UpdateHopDongLaoDong(HopDongLaoDong hopDong);
    }
}
