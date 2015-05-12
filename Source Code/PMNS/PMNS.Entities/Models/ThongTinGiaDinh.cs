using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class ThongTinGiaDinh
    {
        public int idThongTinGiaDinh { get; set; }
        public int idNhanVien { get; set; }
        public string hoTenCha { get; set; }
        public System.DateTime namSinhCha { get; set; }
        public string ngheNghiepCha { get; set; }
        public string hoTenMe { get; set; }
        public System.DateTime namSinhMe { get; set; }
        public string ngheNghiepMe { get; set; }
        public string hoTenVoChong { get; set; }
        public string ngheNghiepVoChong { get; set; }
        public string namSinhVoChong { get; set; }
        public string hoTenCon { get; set; }
        public System.DateTime namSinhCon { get; set; }
        public string ngheNghiepCon { get; set; }
        public virtual ThongTinNhanVIen ThongTinNhanVIen { get; set; }
    }
}
