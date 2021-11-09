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
    public class ServicioAsmOrden : IServicioAsmOrden
    {
        private readonly IRepoOrden _repoOrden;
        private readonly IRepoMenu _repoMenu;
        private readonly IMapper _mapper;

        public ServicioAsmOrden(IRepoOrden repoOrden, IRepoMenu repoMenu, IMapper mapper)
        {
            _repoOrden = repoOrden;
            _repoMenu = repoMenu;
            _mapper = mapper;


        }

        ///  <inheritdoc/>
        public void AgregarSeleccionBebida(int pedidoId, Bebida bebida, Seleccion seleccion)
        {
            throw new NotImplementedException();
        }


        ///  <inheritdoc/>
        public void AgregarSeleccionPlato(int pedidoId, Plato plato, Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Pedido EliminarSeleccion(int seleccionId)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Pedido NuevoPedido()
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Pedido ObtenerPedido(int pedidoId)
        {
            var pedido = _repoOrden.ObtenerPedidoPorId(pedidoId);
            return  _mapper.Map<Pedido>(pedido);
            
        }

    }
}
