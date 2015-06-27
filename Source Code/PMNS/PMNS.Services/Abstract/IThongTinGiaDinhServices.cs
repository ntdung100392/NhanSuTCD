namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;

    public interface IThongTinGiaDinhServices
    {
        ThongTinGiaDinh GetThongTinByNhanVienId(int id);
        bool AddThongTinGiaDinh(ThongTinGiaDinh info);
        bool UpdateThongTinGiaDinh(ThongTinGiaDinh info);
    }
}
