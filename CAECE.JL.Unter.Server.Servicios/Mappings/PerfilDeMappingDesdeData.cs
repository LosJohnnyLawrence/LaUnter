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
            CreateMap<Comun.Modelo.Cliente, Datos.Cliente>().ReverseMap();
            CreateMap<Comun.Modelo.Mozo, Datos.Mozo>().ReverseMap();
            CreateMap<Comun.Modelo.Mesa, Datos.Mesa>().ReverseMap();
            CreateMap<Comun.Modelo.Ingrediente, Datos.Ingrediente>().ReverseMap();
            CreateMap<Comun.Modelo.Item, Datos.Item>().ReverseMap();
            CreateMap<Comun.Modelo.Plato, Datos.Plato>().ReverseMap();
            CreateMap<Comun.Modelo.Bebida, Datos.Bebida>().ReverseMap();
            CreateMap<Comun.Modelo.Sector, Datos.Sector>().ReverseMap();
            CreateMap<Comun.Modelo.Pedido, Datos.Pedido>().ReverseMap();
            CreateMap<Comun.Modelo.Categoria, Datos.Categoria>().ReverseMap();
            CreateMap<Comun.Modelo.Estadia, Datos.Estadia>().ReverseMap();
            CreateMap<Comun.Modelo.EstadoMesa, Datos.EstadoMesa>().ReverseMap();
            CreateMap<Comun.Modelo.EstadoPreparacion, Datos.EstadoPreparacion>().ReverseMap();
            CreateMap<Comun.Modelo.RestriccionAlimentaria, Datos.RestriccionAlimentaria>().ReverseMap();
            CreateMap<Comun.Modelo.Seleccion, Datos.Seleccion>().ReverseMap();
            CreateMap<Comun.Modelo.TurnoMozo, Datos.TurnoMozo>().ReverseMap();
            CreateMap<Comun.Modelo.MotivoDevolucion, Datos.MotivoDevolucion>().ReverseMap();

        }


    }
}
