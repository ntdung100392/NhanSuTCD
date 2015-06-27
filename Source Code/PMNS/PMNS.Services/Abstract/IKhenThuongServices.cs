namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Infrastructures;

    public interface IKhenThuongServices
    {
        List<KhenThuong> GetAllKhenThuong();
        KhenThuong GetKhenThuongById(int id);
        bool AddThongTinKhenThuong(KhenThuong khenThuong);
        bool UpdateThongTinKhenThuong(KhenThuong khenThuong);
    }
}
