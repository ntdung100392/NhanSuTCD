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
            List<ThongTinNhanVIen> empList = unitOfWork.Repository<ThongTinNhanVIen>().GetAll().ToList();
            return empList;
        }

        public bool AddNhanVien(string MaNV, int idTo, string userName, string password, int permission, int idBienChe, int idCapBac,
            int idChucVu, int idTP, string CongViecDangLam, string hoTen, int gioiTinh, DateTime namSinh, string nguyenQuan,
            string noiOHienNay, string hoKhau, string CMND, DateTime ngayCapCMND, string noiCapCMND, string soDienThoaiNha,
            string soDienThoaiDiDong, string nguoiBaoLanh, string moiQuanHeBaoLanh, string noiCongTac, DateTime ngayVaoCang,
            DateTime namVaoSongThan, DateTime ngayNhapNgu, string tinhTrangHonNhan, string hinhAnhCaNhan)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                password = EncryptedSecurity.GetMd5Hash(md5Hash, password);
            }
            ThongTinNhanVIen emp = new ThongTinNhanVIen
            {
                MaNV = MaNV,
                idTo = idTo,
                userName = userName,
                password = password,
                permission = permission,
                idBienChe = idBienChe,
                idCapBac = idCapBac,
                idChucVu = idChucVu,
                idTP = idTP,
                CongViecDangLam = CongViecDangLam,
                hoTen = hoTen,
                gioiTinh = Convert.ToByte(gioiTinh),
                namSinh = namSinh,
                nguyenQuan = nguyenQuan,
                noiOHienNay = noiOHienNay,
                hoKhau = hoKhau,
                CMND = CMND,
                ngayCapCMND = ngayCapCMND,
                noiCapCMND = noiCapCMND,
                soDienThoaiNha = soDienThoaiNha,
                soDienThoaiDiDong = soDienThoaiDiDong,
                nguoiBaoLanh = nguoiBaoLanh,
                moiQuanHeBaoLanh = moiQuanHeBaoLanh,
                noiCongTac = noiCongTac,
                ngayVaoCang = ngayVaoCang,
                namVaoSongThan = namVaoSongThan,
                ngayNhapNgu = ngayNhapNgu,
                tinhTrangHonNhan = tinhTrangHonNhan,
                hinhAnhCaNhan = hinhAnhCaNhan
            };
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
