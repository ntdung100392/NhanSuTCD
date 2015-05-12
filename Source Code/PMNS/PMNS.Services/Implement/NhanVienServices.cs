using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;

namespace PMNS.Services.Implement
{
    public class NhanVienServices : Services<ThongTinNhanVIen>, INhanVienServices
    {
        public NhanVienServices(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        { }

        public bool GetEmployeeByNameAndPass(string name, string pass)
        {
            ThongTinNhanVIen emp = unitOfWork.Repository<ThongTinNhanVIen>().
                Get().Where(x => x.userName.Equals(name) && x.password.Equals(pass)).FirstOrDefault();
            if (emp == null)
            {
                emp = new ThongTinNhanVIen();
                return true;
            }
            return false;
        }

        public List<ThongTinNhanVIen> GetAllEmployees()
        {
            List<ThongTinNhanVIen> empList = unitOfWork.Repository<ThongTinNhanVIen>().GetAll().ToList();
            return empList;
        }
    }
}
