﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IThongTinGiaDinhServices : IServices<ThongTinGiaDinh>
    {
        ThongTinGiaDinh GetThongTinByNhanVienId(int id);
        string AddThongTinGiaDinh(ThongTinGiaDinh info);
        string UpdateThongTinGiaDinh(ThongTinGiaDinh info);
    }
}
