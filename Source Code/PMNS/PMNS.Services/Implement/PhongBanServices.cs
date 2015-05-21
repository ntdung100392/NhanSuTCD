﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;
using System.Data;

namespace PMNS.Services.Implement
{
    public class PhongBanServices : Services<PhongDoiToLoaiTo>, IPhongBanServices
    {
        public PhongBanServices(IUnitOfWork unitOfWork)
            : base(unitOfWork) { }

        public List<PhongDoiToLoaiTo> GetAllPhongBan()
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().GetAll().ToList();
        }

        public List<PhongDoiToLoaiTo> GetChildByParentId(int id)
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().Get().Where(x => x.idCha == id).ToList();
        }
    }
}
