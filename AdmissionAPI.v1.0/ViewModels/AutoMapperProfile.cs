﻿using AdmissionAPI.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdmissionAPI.v1._0.ViewModels
{    public class UniStatusProfile : Profile

    {
        public UniStatusProfile()
        {
            CreateMap<UniStatusView, UniStatus>();
        }
        
    }
}
