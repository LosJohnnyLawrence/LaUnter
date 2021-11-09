﻿using AutoMapper;
using CAECE.JL.Unter.Server.API.Controllers;
using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API
{
    public class PerfilMappingDTOs:Profile
    {
        public PerfilMappingDTOs()
        {
            CreateMap<Mesa, AbrirMesaDTO>();
            CreateMap<Mesa, CreateUpdateMesaDTO>();
            CreateMap<Mesa, MesaInformacionDTO>();
            CreateMap<Mesa, MesaQueryDTO>();
            CreateMap<Mozo, MozoInfoDTO>();
        }
    }
}
