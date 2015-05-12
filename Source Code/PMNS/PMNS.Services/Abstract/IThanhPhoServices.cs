﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IThanhPhoServices : IServices<C_ThanhPho>
    {
        List<C_ThanhPho> GetAllThanhPho();
    }
}
