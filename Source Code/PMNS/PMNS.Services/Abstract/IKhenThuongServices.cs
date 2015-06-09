using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IKhenThuongServices:IServices<KhenThuong>
    {
        List<KhenThuong> GetAllKhenThuong();
        KhenThuong GetKhenThuongById(int id);
        bool AddThongTinKhenThuong(KhenThuong khenThuong);
        bool UpdateThongTinKhenThuong(KhenThuong khenThuong);
    }
}
