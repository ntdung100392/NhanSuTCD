using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class LoaiTo
    {
        public int idLoaiTo { get; set; }
        public int idTo { get; set; }
        public string maLoaiTo { get; set; }
        public string tenLoaiTo { get; set; }
        public virtual To To { get; set; }
    }
}
