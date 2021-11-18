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
        private readonly IServicioTrackOrden _servicioTrackOrden;

        public ServicioAsmOrden(IRepoOrden repoOrden, IRepoMenu repoMenu, IMapper mapper, IServicioTrackOrden servicioTrackOrden)
        {
            _repoOrden = repoOrden;
            _repoMenu = repoMenu;
            _mapper = mapper;
            _servicioTrackOrden = servicioTrackOrden;

        }
        ///  <inheritdoc/>
        public Pedido AgregarSeleccion(int pedidoId, Seleccion seleccion)
        {
            return _mapper.Map<Pedido>(_repoOrden.AgregarSeleccionAPedido(_mapper.Map<Datos.Seleccion>(seleccion), pedidoId)) ;
        }

        ///  <inheritdoc/>
        public void EliminarSeleccion(int seleccionId)
        {
            _repoOrden.EliminarSeleccion( seleccionId );
        }

        ///  <inheritdoc/>
        public Pedido NuevoPedido(Pedido pedido)
        {
            var pedidoCreado = _repoOrden.CrearUnPedido(_mapper.Map<Datos.Pedido>(pedido));
           return _mapper.Map<Pedido>(pedidoCreado);
        }

        ///  <inheritdoc/>
        public Pedido ObtenerPedido(int pedidoId)
        {
            var pedido = _repoOrden.ObtenerPedidoPorId(pedidoId);
            return  _mapper.Map<Pedido>(pedido);
            
        }

    }
}
