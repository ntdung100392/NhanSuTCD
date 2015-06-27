using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class ThongTinTrinhDo
    {
        public int idThongTinTrinhDo { get; set; }
        public int idNhanVien { get; set; }
        public int idTrinhDo { get; set; }
        public string noiDaoTao { get; set; }
        public string chuyenNganh { get; set; }
        public string loaiHinh { get; set; }
        public System.DateTime thoiGianTotNghiep { get; set; }
        public string bangCapPhu_CC { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
        public virtual TrinhDo TrinhDo { get; set; }
    }
}
