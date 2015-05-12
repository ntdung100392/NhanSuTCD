using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class TD_DD_BN_TV
    {
        public int idTDDDBNTV { get; set; }
        public int idNhanVien { get; set; }
        public string hoTenDD { get; set; }
        public string noiDung { get; set; }
        public System.DateTime namThucHien { get; set; }
        public string viTriCu { get; set; }
        public string viTriMoi { get; set; }
        public string dienLaoDong { get; set; }
        public string dienHuongLuong { get; set; }
        public string soQuyetDinh { get; set; }
        public Nullable<System.DateTime> ngayKyQD { get; set; }
        public Nullable<System.DateTime> ngayHieuLuc { get; set; }
        public string ghiChu { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
    }
}
