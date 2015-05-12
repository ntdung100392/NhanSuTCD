using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;

namespace PMNS.Services.Abstract
{
    public interface INhanVienServices : IServices<C_ThongTinNguoiLaoDong>
    {
        bool GetEmployeeByNameAndPass(string name, string pass);
        List<C_ThongTinNguoiLaoDong> GetAllEmployees();
    }
}
