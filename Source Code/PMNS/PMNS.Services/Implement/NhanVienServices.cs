﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;

namespace PMNS.Services.Implement
{
    public class NhanVienServices : Services<C_ThongTinNguoiLaoDong>, INhanVienServices
    {
        public NhanVienServices(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        { }

        public bool GetEmployeeByNameAndPass(string name, string pass)
        {
            C_ThongTinNguoiLaoDong emp = unitOfWork.Repository<C_ThongTinNguoiLaoDong>().
                Get().Where(x => x.C_user.Equals(name) && x.C_Password.Equals(pass)).FirstOrDefault();
            if (emp == null)
            {
                emp = new C_ThongTinNguoiLaoDong();
                return true;
            }
            return false;
        }

        public List<C_ThongTinNguoiLaoDong> GetAllEmployees()
        {
            List<C_ThongTinNguoiLaoDong> empList = unitOfWork.Repository<C_ThongTinNguoiLaoDong>().GetAll().ToList();
            return empList;
        }
    }
}
