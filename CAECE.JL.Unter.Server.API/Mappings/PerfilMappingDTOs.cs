using AutoMapper;
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
            CreateMap<Comun.Modelo.Cliente, Controllers.Cliente>().ReverseMap();
            CreateMap<Comun.Modelo.Mozo, Controllers.Mozo>().ReverseMap();
            CreateMap<Comun.Modelo.Mesa, Controllers.Mesa>().ReverseMap();
            CreateMap<Comun.Modelo.Ingrediente, Controllers.Ingrediente>().ReverseMap();
            CreateMap<Comun.Modelo.Plato, Controllers.Plato>().ReverseMap();
            CreateMap<Comun.Modelo.Bebida, Controllers.Bebida>().ReverseMap();
            CreateMap<Comun.Modelo.Item, Controllers.Item>().ReverseMap();
            CreateMap<Comun.Modelo.Sector, Controllers.Sector>().ReverseMap();
            CreateMap<Comun.Modelo.Pedido, Controllers.Pedido>().ReverseMap();
            CreateMap<Comun.Modelo.Categoria, Controllers.Categoria>().ReverseMap();
            CreateMap<Comun.Modelo.Estadia, Controllers.Estadia>().ReverseMap();
            CreateMap<Comun.Modelo.EstadoMesa, Controllers.EstadoMesa>().ReverseMap();
            CreateMap<Comun.Modelo.EstadoPreparacion, Controllers.EstadoPreparacion>().ReverseMap();
            CreateMap<Comun.Modelo.RestriccionAlimentaria, Controllers.RestriccionAlimentaria>().ReverseMap();
            CreateMap<Comun.Modelo.Seleccion, Controllers.Seleccion>().ReverseMap();
            CreateMap<Comun.Modelo.TurnoMozo, Controllers.TurnoMozo>().ReverseMap();
            CreateMap<Comun.Modelo.MotivoDevolucion, Controllers.MotivoDevolucion>().ReverseMap();
        }
    }
}
