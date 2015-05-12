using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class TrinhDo
    {
        public int idTrinhDo { get; set; }
        public int idNhanVien { get; set; }
        public string vanHoa { get; set; }
        public string trinhDo1 { get; set; }
        public string noiDaoTao { get; set; }
        public string chuyenNganh { get; set; }
        public string loaiHinh { get; set; }
        public Nullable<System.DateTime> thoiGianTotNghiep { get; set; }
        public string bangCapPhu_CC { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
    }
}
