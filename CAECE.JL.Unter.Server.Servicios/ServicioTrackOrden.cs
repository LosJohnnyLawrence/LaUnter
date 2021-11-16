using AutoMapper;
using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Datos.Interfaces;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class ServicioTrackOrden : IServicioTrackOrden
    {
        private readonly IRepoEstadoPreparacion _repoEstados;
        private readonly IMapper _mapper;

        public ServicioTrackOrden(IRepoEstadoPreparacion repoEstados, IMapper mapper)
        {
            _repoEstados = repoEstados;
            _mapper = mapper;

        } 
        ///  <inheritdoc/>
        public void CompletarPedido(Pedido pedido)
        {
            _repoEstados.ActualizarEstado();
        }

        ///  <inheritdoc/>
        public void CompletarSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void DevolverPedido(Pedido pedido, string motivo)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void DevolverSeleccion(Seleccion seleccion, string motivo)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void ObtenerEstadoDePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void ObtenerEstadoDeSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void PedidoListoEntregar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void PonerPedidoEnProgreso(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void PonerSeleccionEnProgreso(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void SeleccionListoEntregar(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }
    }
}
