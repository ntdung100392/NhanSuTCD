using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThongTinKyLuat
    {
        public string C_MaNV { get; set; }
        public Nullable<System.DateTime> C_ThangNamKyLuat { get; set; }
        public string C_LoaiKyLuat { get; set; }
        public string C_CapKyLuat { get; set; }
        public string C_SoQuyetDinhKyLuat { get; set; }
        public string C_NguoiKyQuyetDinh { get; set; }
        public string C_HanhViBiKyLuat { get; set; }
        public string C_GhiChu { get; set; }
        public virtual C_ThongTinNguoiLaoDong C_ThongTinNguoiLaoDong { get; set; }
    }
}