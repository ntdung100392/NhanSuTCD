using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IThongTinServices : IServices<TD_DD_BN_TV>
    {
        List<TD_DD_BN_TV> GetAllThongTin();
        List<TD_DD_BN_TV> GetThongTinByEmpId(int empId);
        TD_DD_BN_TV GetThongTinById(int id);
        bool AddThongTin(TD_DD_BN_TV thongTin);
        bool UpdateThongTin(TD_DD_BN_TV thongTin);
        List<TD_DD_BN_TV> FindThongTin(string condition);
    }
}
