﻿namespace PMNS.Services.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Security.Cryptography;

    using PMNS.Services.Abstract;
    using PMNS.DAL.Abstract;
    using PMNS.Entities.Models;
    using PMNS.Services.Models;
    using PMNS.Services.Method;
    using PMNS.Infranstructures.Implement;

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

        public ThongTinNhanVIen GetEmpByMaNV(string maNV)
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().Get(x => x.MaNV.Equals(maNV)).FirstOrDefault();
        }

        public List<string> FindEmpByMaNV(string maNV)
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().Get().Where(x => x.MaNV.Contains(maNV)).ToList()
                .Select(x => x.MaNV).ToList();
        }

        public List<string> FindEmpByName(string name)
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().Get().Where(x => x.hoTen.Contains(name)).ToList()
                .Select(x => x.hoTen).ToList();
        }

        public ThongTinNhanVIen GetEmpById(int id)
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().GetById(id);
        }

        public bool UpdateEmpInfo(ThongTinNhanVIen emp)
        {
            if (emp != null)
            {
                try
                {
                    unitOfWork.Repository<ThongTinNhanVIen>().Update(emp);
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

        public List<ThongTinNhanVIen> GetAllNhanVienByIdPhongBan(int id)
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().GetAll().
                Where(x => x.idPhongDoiToLoai == id).ToList().OrderBy(x => x.MaNV).ToList();
        }

        public List<ThongTinNhanVIen> FindEmp(string condition)
        {
            return unitOfWork.Repository<ThongTinNhanVIen>().Get().
                Where(x => x.MaNV.Contains(condition) || x.hoTen.Contains(condition)).ToList();
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
