namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Infrastructures;

    public interface IThongTinTrinhDoServices
    {
        List<ThongTinTrinhDo> GetThongTinTrinhDoByEmpId(int empId);
        List<ThongTinTrinhDo> GetAllThongTinTrinhDo();
        ThongTinTrinhDo GetThongTinTrinhDoById(int id);
        bool AddThongTinTrinhDo(ThongTinTrinhDo trinhDo);
        bool UpdateThongTinTrinhDo(ThongTinTrinhDo trinhDo);
        bool DeleteThongTinTrinhDo(ThongTinTrinhDo trinhDo);
    }
}
