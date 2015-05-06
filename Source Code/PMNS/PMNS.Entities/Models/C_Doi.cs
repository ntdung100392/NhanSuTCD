using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_Doi
    {
        public C_Doi()
        {
            this.C_ThongTinNguoiLaoDong = new List<C_ThongTinNguoiLaoDong>();
            this.C_To = new List<C_To>();
        }

        public string C_MaDoi { get; set; }
        public string C_MaPhong { get; set; }
        public string C_TenDoi { get; set; }
        public virtual C_Phong C_Phong { get; set; }
        public virtual ICollection<C_ThongTinNguoiLaoDong> C_ThongTinNguoiLaoDong { get; set; }
        public virtual ICollection<C_To> C_To { get; set; }
    }
}
