using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;
using PMNS.Services.Implement;

namespace PMNS.Services.Abstract
{
    public interface INguoiLaoDongServices : IService<C_ThongTinNguoiLaoDong>
    {
        C_ThongTinNguoiLaoDong GetEmployeeByNameAndPass(string name, string pass);
    }
}
