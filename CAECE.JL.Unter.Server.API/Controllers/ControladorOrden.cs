using AutoMapper;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    [Route("api/orden")]
    [ApiController]
    public class ControladorOrden : Controller
    {
        private readonly IServicioAsmOrden _servicioAsmOrden;
        private readonly IMapper _mapper;

        public ControladorOrden(IServicioAsmOrden servicioAsmOrden, IMapper mapper)
        {
            _servicioAsmOrden = servicioAsmOrden;
            _mapper = mapper;

        }

        [HttpPost]
        /// <summary>
        /// Crea un nuevo peido y perisiste su data, 
        /// devuelve el Id para operar con ella a que la API es stateles
        /// </summary>
        /// <param name="pedido">Datos peara crear nuevo pedido, datos del cliente, moxo y mesa son requeridos </param>
        /// <returns> Data nuevo Pedido</returns>
        public Pedido NuevoPedido(Pedido pedido) {
            return _mapper.Map<Pedido>( _servicioAsmOrden.NuevoPedido( _mapper.Map<Comun.Modelo.Pedido>(pedido)));
        }


        [HttpPut]
        /// <summary>
        /// Añade un nuevo item al pedido ya seea Bebida,
        /// comida o promocion
        /// </summary>
        /// <param name="pedidoId">Id del pedido para operar</param>
        /// <param name="seleccion">Describe como se modifica el plato base</param>
        public Pedido AgregarSeleccion(int pedidoId, Seleccion seleccion)
        {
            return _mapper.Map<Pedido>(_servicioAsmOrden.AgregarSeleccion(pedidoId,_mapper.Map<Comun.Modelo.Seleccion>(seleccion)));
        }


        [HttpDelete]
        /// <summary>
        /// Elimina una seleccion de un pedido
        /// </summary>
        /// <param name="seleccionId">Id de la seleccion a eliminar</param>
        /// <returns>El nuevo estado del pedido</returns>
        public void EliminarSeleccion(int seleccionId)
        {
            _servicioAsmOrden.EliminarSeleccion(seleccionId);
        }


        [HttpGet]
        /// <summary>
        /// Devuelve el pedido ensamblado
        /// </summary>
        /// <param name="pedidoId">d del pedido para obetener</param>
        /// <returns>El pedido ensambaldo</returns>
        public Pedido ObtenerPedido(int pedidoId)
        {
            return _mapper.Map<Pedido>(_servicioAsmOrden.ObtenerPedido(pedidoId));
        }

    }
}
