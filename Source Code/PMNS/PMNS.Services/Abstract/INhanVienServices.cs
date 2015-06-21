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
    public interface INhanVienServices : IServices<ThongTinNhanVIen>
    {
        string GetEmployeeByNameAndPass(string name, string pass);
        List<ThongTinNhanVIen> GetAllEmployees();
        bool AddNhanVien(ThongTinNhanVIen emp);
        ThongTinNhanVIen GetEmpByMaNV(string maNV);
        List<string> FindEmpByMaNV(string maNV);
        List<string> FindEmpByName(string name);
        ThongTinNhanVIen GetEmpById(int id);
        bool UpdateEmpInfo(ThongTinNhanVIen emp);
        List<ThongTinNhanVIen> GetAllNhanVienByIdPhongBan(int id);
        List<ThongTinNhanVIen> FindEmp(string condition);
    }
}
