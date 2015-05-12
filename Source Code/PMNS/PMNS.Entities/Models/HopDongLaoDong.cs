using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class HopDongLaoDong
    {
        public int idHopDongLaoDong { get; set; }
        public int idNhanVien { get; set; }
        public string soHopDong_TTHDLD { get; set; }
        public string nguoiBaoLanh_TTHDLD { get; set; }
        public string chucDanh { get; set; }
        public string idLoaiHopDong { get; set; }
        public System.DateTime ngayBatDau { get; set; }
        public System.DateTime ngayKetThuc { get; set; }
        public string ghiChu { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
    }
}
