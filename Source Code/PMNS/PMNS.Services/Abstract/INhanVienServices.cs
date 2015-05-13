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
        bool AddNhanVien(string MaNV, int idTo, string userName, string password, int permission, int idBienChe, int idCapBac,
            int idChucVu, int idTP, string CongViecDangLam, string hoTen, int gioiTinh, DateTime namSinh, string nguyenQuan,
            string noiOHienNay, string hoKhau, string CMND, DateTime ngayCapCMND, string noiCapCMND, string soDienThoaiNha,
            string soDienThoaiDiDong, string nguoiBaoLanh, string moiQuanHeBaoLanh, string noiCongTac, DateTime ngayVaoCang,
            DateTime namVaoSongThan, DateTime ngayNhapNgu, string tinhTrangHonNhan, string hinhAnhCaNhan);
    }
}
