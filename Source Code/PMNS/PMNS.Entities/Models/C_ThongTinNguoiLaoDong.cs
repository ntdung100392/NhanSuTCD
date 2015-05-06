using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThongTinNguoiLaoDong
    {
        public C_ThongTinNguoiLaoDong()
        {
            this.TD_DD_BN_TV = new List<TD_DD_BN_TV>();
        }

        public string C_MaNV { get; set; }
        public string C_MaPhongBan { get; set; }
        public string C_MaDoi { get; set; }
        public string C_MaLoaiTo { get; set; }
        public string C_MaTo { get; set; }
        public string C_user { get; set; }
        public string C_Password { get; set; }
        public string C_PhanQuyen { get; set; }
        public string C_BienChe { get; set; }
        public string C_CapBac { get; set; }
        public string C_ChucVu { get; set; }
        public string C_MaChucVu { get; set; }
        public string C_CongViecDangLam { get; set; }
        public string C_HoTen { get; set; }
        public string C_GioiTinh { get; set; }
        public Nullable<System.DateTime> C_NamSinh { get; set; }
        public string C_NguyenQuan { get; set; }
        public string C_NoiOHienNay { get; set; }
        public string C_HoKhau { get; set; }
        public string C_CMND { get; set; }
        public Nullable<System.DateTime> C_NgayCapCMND { get; set; }
        public string C_NoiCapCMND { get; set; }
        public string C_SDTNha { get; set; }
        public string C_SDTDD { get; set; }
        public string C_NguoiBaoLanh { get; set; }
        public string C_MoiQuanHeNBL { get; set; }
        public string C_NoiCongTac { get; set; }
        public Nullable<System.DateTime> C_NgayVaoCang { get; set; }
        public Nullable<System.DateTime> C_NamVaoST { get; set; }
        public Nullable<System.DateTime> C_NgayNhapNgu { get; set; }
        public string C_TinhTrangHonNhan { get; set; }
        public string C_HinhAnhCaNhan { get; set; }
        public string C_MaTP { get; set; }
        public virtual C_Doi C_Doi { get; set; }
        public virtual C_LoaiTo C_LoaiTo { get; set; }
        public virtual C_Phong C_Phong { get; set; }
        public virtual C_ThanhPho C_ThanhPho { get; set; }
        public virtual C_ThongTinGiaDinh C_ThongTinGiaDinh { get; set; }
        public virtual C_ThongTinHopDongLaoDong C_ThongTinHopDongLaoDong { get; set; }
        public virtual C_ThongTinKhenThuong C_ThongTinKhenThuong { get; set; }
        public virtual C_ThongTinKyLuat C_ThongTinKyLuat { get; set; }
        public virtual C_To C_To { get; set; }
        public virtual C_ThongTinTrinhDo C_ThongTinTrinhDo { get; set; }
        public virtual ICollection<TD_DD_BN_TV> TD_DD_BN_TV { get; set; }
    }
}
