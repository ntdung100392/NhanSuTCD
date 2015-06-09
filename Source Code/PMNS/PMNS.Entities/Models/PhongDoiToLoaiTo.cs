using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class PhongDoiToLoaiTo
    {
        public PhongDoiToLoaiTo()
        {
            this.PhongDoiToLoaiTo1 = new List<PhongDoiToLoaiTo>();
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idPhongDoiToLoai { get; set; }
        public string maPhongDoiToLoai { get; set; }
        public string tenPhongDoiToLoai { get; set; }
        public int idCha { get; set; }
        public virtual ICollection<PhongDoiToLoaiTo> PhongDoiToLoaiTo1 { get; set; }
        public virtual PhongDoiToLoaiTo PhongDoiToLoaiTo2 { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
