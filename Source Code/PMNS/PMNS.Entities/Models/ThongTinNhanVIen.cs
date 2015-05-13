using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class ThongTinNhanVIen
    {
        public ThongTinNhanVIen()
        {
            this.HopDongLaoDongs = new List<HopDongLaoDong>();
            this.KhenThuongs = new List<KhenThuong>();
            this.KyLuats = new List<KyLuat>();
            this.TD_DD_BN_TV = new List<TD_DD_BN_TV>();
            this.ThongTinGiaDinhs = new List<ThongTinGiaDinh>();
            this.TrinhDoes = new List<TrinhDo>();
        }

        public int idNhanVien { get; set; }
        public string MaNV { get; set; }
        public int idTo { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public int permission { get; set; }
        public int idBienChe { get; set; }
        public int idCapBac { get; set; }
        public int idChucVu { get; set; }
        public int idTP { get; set; }
        public string CongViecDangLam { get; set; }
        public string hoTen { get; set; }
        public byte gioiTinh { get; set; }
        public System.DateTime namSinh { get; set; }
        public string nguyenQuan { get; set; }
        public string noiOHienNay { get; set; }
        public string hoKhau { get; set; }
        public string CMND { get; set; }
        public Nullable<System.DateTime> ngayCapCMND { get; set; }
        public string noiCapCMND { get; set; }
        public string soDienThoaiNha { get; set; }
        public string soDienThoaiDiDong { get; set; }
        public string nguoiBaoLanh { get; set; }
        public string moiQuanHeBaoLanh { get; set; }
        public string noiCongTac { get; set; }
        public Nullable<System.DateTime> ngayVaoCang { get; set; }
        public Nullable<System.DateTime> namVaoSongThan { get; set; }
        public Nullable<System.DateTime> ngayNhapNgu { get; set; }
        public string tinhTrangHonNhan { get; set; }
        public string hinhAnhCaNhan { get; set; }
        public virtual BienChe BienChe { get; set; }
        public virtual CapBac CapBac { get; set; }
        public virtual ChucVu ChucVu { get; set; }
        public virtual ICollection<HopDongLaoDong> HopDongLaoDongs { get; set; }
        public virtual ICollection<KhenThuong> KhenThuongs { get; set; }
        public virtual ICollection<KyLuat> KyLuats { get; set; }
        public virtual ICollection<TD_DD_BN_TV> TD_DD_BN_TV { get; set; }
        public virtual ThanhPho ThanhPho { get; set; }
        public virtual ICollection<ThongTinGiaDinh> ThongTinGiaDinhs { get; set; }
        public virtual To To { get; set; }
        public virtual ICollection<TrinhDo> TrinhDoes { get; set; }
    }
}
