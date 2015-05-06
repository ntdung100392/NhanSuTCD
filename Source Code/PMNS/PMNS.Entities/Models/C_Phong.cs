using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_Phong
    {
        public C_Phong()
        {
            this.C_Doi = new List<C_Doi>();
            this.C_ThongTinNguoiLaoDong = new List<C_ThongTinNguoiLaoDong>();
        }

        public string C_MaPhong { get; set; }
        public string C_TenPhong { get; set; }
        public virtual ICollection<C_Doi> C_Doi { get; set; }
        public virtual ICollection<C_ThongTinNguoiLaoDong> C_ThongTinNguoiLaoDong { get; set; }
    }
}
