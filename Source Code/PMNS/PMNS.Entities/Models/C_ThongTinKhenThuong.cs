using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThongTinKhenThuong
    {
        public string C_MaNV { get; set; }
        public Nullable<System.DateTime> C_NamKhenThuong { get; set; }
        public string C_LoaiKhenThuong { get; set; }
        public string C_CapKhenThuong { get; set; }
        public string C_SoSoKhenThuong { get; set; }
        public string C_NguoiKyKhenThuong { get; set; }
        public string C_ThanhTichKhenThuong { get; set; }
        public string C_GhiChu { get; set; }
        public virtual C_ThongTinNguoiLaoDong C_ThongTinNguoiLaoDong { get; set; }
    }
}
