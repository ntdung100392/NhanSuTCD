using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;
using PMNS.Services.Models;
using System.Security.Cryptography;

namespace PMNS.Services.Implement
{
    public class NhanVienServices : Services<ThongTinNhanVIen>, INhanVienServices
    {
        public NhanVienServices(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        { }

        public string GetEmployeeByNameAndPass(string name, string pass)
        {
            ThongTinNhanVIen emp = unitOfWork.Repository<ThongTinNhanVIen>().
                Get().Where(x => x.userName.Equals(name)).FirstOrDefault();            
            if (emp != null)
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    if (EncryptedSecurity.VerifyMd5Hash(md5Hash, pass, emp.password))
                    {
                        InitUserProfile(emp);
                        return "Chào Mừng Đến Với PMNS!";
                    }
                    else
                    {
                        return "Mật Khẩu Không Đúng!";
                    }
                }
            }
            else
            {
                return "Không Tồn Tại Tài Khoản Này Trong Cơ Sở Dữ Liệu!";
            }
        }

        public List<ThongTinNhanVIen> GetAllEmployees()
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().GetAll().ToList();
        }

        public bool AddNhanVien(ThongTinNhanVIen emp)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                emp.password = EncryptedSecurity.GetMd5Hash(md5Hash, emp.password);
            }
            if (emp != null)
            {
                try
                {
                    unitOfWork.Repository<ThongTinNhanVIen>().Insert(emp);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    throw e;
                }
            }
            return false;
        }

        private void InitUserProfile(ThongTinNhanVIen emp)
        {
            UserProfile.idNhanVien = emp.idNhanVien;
            UserProfile.MaNV = emp.MaNV;
            UserProfile.hoTen = emp.hoTen;
            UserProfile.userName = emp.userName;
            UserProfile.permission = emp.permission;
        }
    }
}
