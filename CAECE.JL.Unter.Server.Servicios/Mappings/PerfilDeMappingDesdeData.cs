using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class PerfilDeMappingDesdeData : Profile
    {


        public PerfilDeMappingDesdeData()
        {
            CreateMap<Comun.Modelo.Cliente, Datos.Cliente>();
            CreateMap<Comun.Modelo.Mozo, Datos.Mozo>();
            CreateMap<Comun.Modelo.Mesa, Datos.Mesa>();
            CreateMap<Comun.Modelo.Ingrediente, Datos.Ingrediente>();
            CreateMap<Comun.Modelo.Plato, Datos.Plato>();
            CreateMap<Comun.Modelo.Bebida, Datos.Bebida>();
            CreateMap<Comun.Modelo.Sector, Datos.Sector>();
            CreateMap<Comun.Modelo.Pedido, Datos.Pedido>();
            CreateMap<Comun.Modelo.Categoria, Datos.Categoria>();
            CreateMap<Comun.Modelo.Estadia, Datos.Estadia>();
            CreateMap<Comun.Modelo.EstadoMesa, Datos.EstadoMesa>();
            CreateMap<Comun.Modelo.EstadoPreparacion, Datos.EstadoPreparacion>();
            CreateMap<Comun.Modelo.RestriccionAlimentaria, Datos.RestriccionAlimentaria>();
            CreateMap<Comun.Modelo.Seleccion, Datos.Seleccion>();
            CreateMap<Comun.Modelo.TurnoMozo, Datos.TurnoMozo>();

        }


    }
}
