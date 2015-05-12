using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class KhenThuong
    {
        public int idKhenThuong { get; set; }
        public int idNhanVien { get; set; }
        public System.DateTime namKhenThuong { get; set; }
        public string loaiKhenThuong { get; set; }
        public string capKhenThuong { get; set; }
        public string soSoKhenThuong { get; set; }
        public string nguoiKhenThuong { get; set; }
        public string thanhTichKhenThuong { get; set; }
        public string ghiChu { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
    }
}
