using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IThongTinTrinhDoServices : IServices<TrinhDo>
    {
        List<TrinhDo> GetThongTinTrinhDoByEmpId(int empId);
        List<TrinhDo> GetAllThongTinTrinhDo();
        TrinhDo GetThongTinTrinhDoById(int id);
        bool AddThongTinTrinhDo(TrinhDo trinhDo);
        bool UpdateThongTinTrinhDo(TrinhDo trinhDo);
        bool DeleteThongTinTrinhDo(TrinhDo trinhDo);
    }
}
