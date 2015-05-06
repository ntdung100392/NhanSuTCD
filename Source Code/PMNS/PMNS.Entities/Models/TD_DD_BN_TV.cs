using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class TD_DD_BN_TV
    {
        public int C_MaDDTDBNTV { get; set; }
        public string C_MaNV { get; set; }
        public string C_HoTenDD { get; set; }
        public string C_NoiDung { get; set; }
        public Nullable<System.DateTime> C_NamThucHien { get; set; }
        public string C_ViTriCu { get; set; }
        public string C_ViTriMoi { get; set; }
        public string C_DienLaoDong { get; set; }
        public string C_DienHuongLuong { get; set; }
        public string C_SoQuyetDinh { get; set; }
        public Nullable<System.DateTime> C_NgayKyQD { get; set; }
        public Nullable<System.DateTime> C_NgayHieuLuc { get; set; }
        public string C_GhiChu { get; set; }
        public virtual C_ThongTinNguoiLaoDong C_ThongTinNguoiLaoDong { get; set; }
    }
}
