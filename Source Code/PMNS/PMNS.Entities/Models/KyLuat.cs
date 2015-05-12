using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class KyLuat
    {
        public int idKyLuat { get; set; }
        public int idNhanVien { get; set; }
        public System.DateTime ngayKyLuat { get; set; }
        public string loaiKyLuat { get; set; }
        public string capKyLuat { get; set; }
        public string soQuyetDinhKyLuat { get; set; }
        public string nguoiKyQuyetDinh { get; set; }
        public string hanhViBiKyLuat { get; set; }
        public string ghiChu { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
    }
}
