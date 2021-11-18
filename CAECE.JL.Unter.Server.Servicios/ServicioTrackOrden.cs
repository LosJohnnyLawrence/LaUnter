using AutoMapper;
using CAECE.JL.Unter.Server.Comun.Interfaces;
using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Datos.Interfaces;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using System;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class ServicioTrackOrden : IServicioTrackOrden
    {
        private readonly IRepoEstadoPreparacion _repoEstados;
        private readonly IRepoOrden _repoOrden;
        private readonly IMapper _mapper;
        private readonly IProviderEstados _providerEstados;

        public ServicioTrackOrden(IRepoEstadoPreparacion repoEstados, IRepoOrden repoOrden, IMapper mapper, IProviderEstados providerEstados)
        {
            _repoEstados = repoEstados;
            _repoOrden = repoOrden;
            _mapper = mapper;
            _providerEstados = providerEstados;

        }

        public void CancelarPedido(Pedido pedido, string motivo)
        {
            _repoOrden.
        }

        public void CancelarSeleccion(Seleccion seleccion, string motivo)
        {
            throw new NotImplementedException();
        }

        public void DevolverEstadoPedido(Pedido pedido, string motivo)
        {
            throw new NotImplementedException();
        }

        public void DevolverEstadoSeleccion(Seleccion seleccion, string motivo)
        {
            throw new NotImplementedException();
        }

        public EstadoPreparacion ObtenerEstadoDePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public EstadoPreparacion ObtenerEstadoDeSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public void PasarestadoPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void PasarestadoSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }
    }
}
