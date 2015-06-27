namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Services.Abstract;
    using PMNS.Entities.Models;
    using PMNS.DAL.Abstract;
    using PMNS.Infrastructures;

    public interface IPhongBanServices
    {
        List<PhongDoiToLoaiTo> GetAllPhongBan();
        List<PhongDoiToLoaiTo> GetChildByParentId(int id);
        int GetParentByChildId(int id);
        PhongDoiToLoaiTo GetPhongBanById(int id);
        bool AddPhongBan(PhongDoiToLoaiTo phongBan);
        bool UpdatePhongBan(PhongDoiToLoaiTo phongBan);
        PhongDoiToLoaiTo FindPhongBanByNameAndCode(string maPhongBan, string tenPhongBan);
    }
}
