using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThongTinTrinhDo
    {
        public string C_MaNV { get; set; }
        public string C_VanHoa { get; set; }
        public string C_TrinhDo { get; set; }
        public string C_NoiDaoTao { get; set; }
        public string C_ChuyenNganh { get; set; }
        public string C_LoaiHinh { get; set; }
        public Nullable<System.DateTime> C_ThoiGianTotNghiep { get; set; }
        public string C_BangCapPhu_CC { get; set; }
        public virtual C_ThongTinNguoiLaoDong C_ThongTinNguoiLaoDong { get; set; }
    }
}
