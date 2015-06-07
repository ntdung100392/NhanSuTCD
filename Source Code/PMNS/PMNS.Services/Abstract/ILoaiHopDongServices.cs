using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface ILoaiHopDongServices : IServices<LoaiHopDong>
    {
        List<LoaiHopDong> GettAllLoaiHopDong();
        LoaiHopDong GetLoaiHopDongById(int id);
        bool AddLoaiHopDong(LoaiHopDong loaiHopDong);
        bool UpdateLoaiHopDong(LoaiHopDong loaiHopDong);
    }
}
