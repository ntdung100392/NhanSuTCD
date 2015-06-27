namespace PMNS.Services.Implement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;

    using PMNS.Services.Abstract;
    using PMNS.Entities.Models;
    using PMNS.DAL.Abstract;
    using PMNS.Infranstructures.Implement;

    public class PhongBanServices : Services<PhongDoiToLoaiTo>, IPhongBanServices
    {
        public PhongBanServices(IUnitOfWork unitOfWork)
            : base(unitOfWork) { }

        public List<PhongDoiToLoaiTo> GetAllPhongBan()
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().GetAll().OrderBy(x=>x.tenPhongDoiToLoai).ToList();
        }

        public List<PhongDoiToLoaiTo> GetChildByParentId(int id)
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().Get().Where(x => x.idCha == id).ToList();
        }

        public int GetParentByChildId(int id)
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().GetById(id).idPhongDoiToLoai;
        }

        public PhongDoiToLoaiTo GetPhongBanById(int id)
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().GetById(id);
        }

        public bool AddPhongBan(PhongDoiToLoaiTo phongBan)
        {
            if (phongBan != null)
            {
                try
                {
                    unitOfWork.Repository<PhongDoiToLoaiTo>().Insert(phongBan);
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

        public bool UpdatePhongBan(PhongDoiToLoaiTo phongBan)
        {
            if (phongBan != null)
            {
                try
                {
                    unitOfWork.Repository<PhongDoiToLoaiTo>().Update(phongBan);
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

        public PhongDoiToLoaiTo FindPhongBanByNameAndCode(string maPhongBan, string tenPhongBan)
        {
            return unitOfWork.Repository<PhongDoiToLoaiTo>().Get()
                .Where(x => x.maPhongDoiToLoai.Equals(maPhongBan) || x.tenPhongDoiToLoai.Equals(tenPhongBan)).FirstOrDefault();
        }
    }
}
