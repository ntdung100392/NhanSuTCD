using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_To
    {
        public C_To()
        {
            this.C_LoaiTo = new List<C_LoaiTo>();
            this.C_ThongTinNguoiLaoDong = new List<C_ThongTinNguoiLaoDong>();
        }

        public string C_MaTo { get; set; }
        public string C_MaDoi { get; set; }
        public string C_TenTo { get; set; }
        public virtual C_Doi C_Doi { get; set; }
        public virtual ICollection<C_LoaiTo> C_LoaiTo { get; set; }
        public virtual ICollection<C_ThongTinNguoiLaoDong> C_ThongTinNguoiLaoDong { get; set; }
    }
}
