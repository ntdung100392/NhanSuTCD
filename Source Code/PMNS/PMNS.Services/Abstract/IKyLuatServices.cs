namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;

    public interface IKyLuatServices
    {
        List<KyLuat> GetAllKyLuat();
        KyLuat GetKyLuatById(int id);
        bool AddThongTinKyLuat(KyLuat kyLuat);
        bool UpdateThongTinKyLuat(KyLuat kyLuat);
    }
}
