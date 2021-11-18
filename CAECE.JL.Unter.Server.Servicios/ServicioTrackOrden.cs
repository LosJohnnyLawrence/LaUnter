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
            var estadoActual = _providerEstados.ObtenerEstado(pedido.Estado.Nombre);
            estadoActual.AsignarPreparacion(pedido);
            estadoActual.Cancelar();
            estadoActual.Notificar(estadoActual.ObtenerNombre(), motivo);
            var pedidoMappeado = _mapper.Map<Datos.Pedido>(pedido);
            _repoEstados.PersistirMotivo(motivo, pedidoMappeado);
            _repoOrden.ActualizarPedido(pedidoMappeado);

        }

        public void DevolverEstadoPedido(Pedido pedido, string motivo)
        {
            var estadoActual = _providerEstados.ObtenerEstado(pedido.Estado.Nombre);
            estadoActual.AsignarPreparacion(pedido);
            estadoActual.DevolverEstado();
            estadoActual.Notificar(estadoActual.ObtenerNombre(), motivo);
            var pedidoMappeado = _mapper.Map<Datos.Pedido>(pedido);
            _repoEstados.PersistirMotivo(motivo, pedidoMappeado);
            _repoOrden.ActualizarPedido(pedidoMappeado);
        }

        public void PasarEstadoPedido(Pedido pedido)
        {
            var estadoActual = _providerEstados.ObtenerEstado(pedido.Estado.Nombre);
            estadoActual.AsignarPreparacion(pedido);
            estadoActual.DevolverEstado();
            estadoActual.Notificar(estadoActual.ObtenerNombre());
            var pedidoMappeado = _mapper.Map<Datos.Pedido>(pedido);
            _repoOrden.ActualizarPedido(pedidoMappeado);
        }
        public EstadoPreparacion ObtenerEstadoDePedido(Pedido pedido)
        {
            return pedido.Estado;
        }
        public EstadoPreparacion ObtenerEstadoDeSeleccion(Seleccion seleccion)
        {
            return seleccion.Estado;
        }
        public void CancelarSeleccion(Seleccion seleccion, string motivo)
        {
            var estadoActual = _providerEstados.ObtenerEstado(seleccion.Estado.Nombre);
            estadoActual.AsignarPreparacion(seleccion);
            estadoActual.Cancelar();
            estadoActual.Notificar(estadoActual.ObtenerNombre(), motivo);
            var seleccionMappeado = _mapper.Map<Datos.Seleccion>(seleccion);
            _repoEstados.PersistirMotivo(motivo, seleccionMappeado.Pedido);
            _repoOrden.ActualizarSeleccion(seleccionMappeado);

        }

        public void DevolverEstadoSeleccion(Seleccion seleccion, string motivo)
        {
            var estadoActual = _providerEstados.ObtenerEstado(seleccion.Estado.Nombre);
            estadoActual.AsignarPreparacion(seleccion);
            estadoActual.DevolverEstado();
            estadoActual.Notificar(estadoActual.ObtenerNombre(), motivo);
            var seleccionMappeado = _mapper.Map<Datos.Seleccion>(seleccion);
            _repoEstados.PersistirMotivo(motivo, seleccionMappeado.Pedido);
            _repoOrden.ActualizarSeleccion(seleccionMappeado);
        }

        public void PasarEstadoSeleccion(Seleccion seleccion)
        {
            var estadoActual = _providerEstados.ObtenerEstado(seleccion.Estado.Nombre);
            estadoActual.AsignarPreparacion(seleccion);
            estadoActual.DevolverEstado();
            estadoActual.Notificar(estadoActual.ObtenerNombre());
            var seleccionMappeado = _mapper.Map<Datos.Seleccion>(seleccion);
            _repoOrden.ActualizarSeleccion(seleccionMappeado);
        }

    }
}
