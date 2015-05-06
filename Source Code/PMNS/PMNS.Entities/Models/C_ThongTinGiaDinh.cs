using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThongTinGiaDinh
    {
        public string C_HoTenCha { get; set; }
        public string C_NgheNghiepCha { get; set; }
        public Nullable<System.DateTime> C_NamSinhCha { get; set; }
        public string C_HoTenMe { get; set; }
        public string C_NgheNghiepMe { get; set; }
        public Nullable<System.DateTime> C_NamSinhMe { get; set; }
        public string C_HoTenVoChong { get; set; }
        public string C_NgheNghiepVoChong { get; set; }
        public Nullable<System.DateTime> C_NamSinhVoChong { get; set; }
        public string C_HoTenCon { get; set; }
        public Nullable<System.DateTime> C_NamSinhCon { get; set; }
        public string C_NgheNghiepCon { get; set; }
        public string C_MaNV { get; set; }
        public virtual C_ThongTinNguoiLaoDong C_ThongTinNguoiLaoDong { get; set; }
    }
}
