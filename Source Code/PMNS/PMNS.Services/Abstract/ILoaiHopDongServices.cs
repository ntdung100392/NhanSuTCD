namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Infrastructures;

    public interface ILoaiHopDongServices
    {
        List<LoaiHopDong> GettAllLoaiHopDong();
        LoaiHopDong GetLoaiHopDongById(int id);
        bool AddLoaiHopDong(LoaiHopDong loaiHopDong);
        bool UpdateLoaiHopDong(LoaiHopDong loaiHopDong);
    }
}
