using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThongTinHopDongLaoDong
    {
        public string C_MaNV { get; set; }
        public string C_SoHopDong_TTHDLD { get; set; }
        public string C_NguoiBaoLanh_TTHDLD { get; set; }
        public string C_ChucDanh { get; set; }
        public string C_HopDong { get; set; }
        public string C_LoaiHopDong { get; set; }
        public Nullable<System.DateTime> C_NgayBatDau { get; set; }
        public Nullable<System.DateTime> C_NgayKetThuc { get; set; }
        public string C_GhiChu { get; set; }
        public virtual C_ThongTinNguoiLaoDong C_ThongTinNguoiLaoDong { get; set; }
    }
}
