namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;

    public interface ITrinhDoServices
    {
        List<TrinhDo> GetAllTrinhDo();
        TrinhDo GetTrinhDoById(int id);
        bool AddTrinhDo(TrinhDo trinhDo);
        bool UpdateTrinhDo(TrinhDo trinhDo);
    }
}
