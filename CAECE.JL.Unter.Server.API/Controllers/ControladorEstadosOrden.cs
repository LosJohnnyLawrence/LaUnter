using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using AutoMapper;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    [Route("api/estados/[action]", Name = "[controller]_[action]")]
    [ApiController]
    public class ControladorEstadosOrden : Controller
    {

        private readonly IServicioTrackOrden _servicioTrackOrden;
        private readonly IMapper _mapper;

        //private readonly ILogger _servicioTrackOrden;


        public ControladorEstadosOrden(IServicioTrackOrden servicioTrackOrden, IMapper mapper)
        {
            _mapper = mapper;
            _servicioTrackOrden = servicioTrackOrden;

        }

        [HttpPut]
        /// <summary>
        /// Avanza al proximo estado del flujo normal dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        public void PasarEstadoPedido(Pedido pedido)
        {
            _servicioTrackOrden.PasarEstadoPedido(_mapper.Map<Comun.Modelo.Pedido>(pedido));
        }

        [HttpPut]
        /// <summary>
        /// Retrocede a un estado de error dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void DevolverEstadoPedido(Pedido pedido, string motivo)
        {
            _servicioTrackOrden.DevolverEstadoPedido(_mapper.Map<Comun.Modelo.Pedido>(pedido), motivo);
        }


        [HttpPut]
        /// <summary>
        /// Lleava al estado terminal de error "cancelado" 
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void CancelarPedido(Pedido pedido, string motivo)
        {
            _servicioTrackOrden.CancelarPedido(_mapper.Map<Comun.Modelo.Pedido>(pedido), motivo);
        }




        [HttpPut]
        /// <summary>
        /// Avanza al proximo estado del flujo normal dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        public void PasarEstadoSeleccion(Seleccion seleccion)
        {
            _servicioTrackOrden.PasarEstadoSeleccion(_mapper.Map<Comun.Modelo.Seleccion>(seleccion));
        }

        [HttpPut]
        /// <summary>
        /// Retrocede a un estado de error dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void DevolverEstadoSeleccion(Seleccion seleccion, string motivo)
        {
            _servicioTrackOrden.DevolverEstadoSeleccion(_mapper.Map<Comun.Modelo.Seleccion>(seleccion), motivo);
        }


        [HttpPut]
        /// <summary>
        /// Lleava al estado terminal de error "cancelado" 
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void CancelarSeleccion(Seleccion seleccion, string motivo)
        {
            _servicioTrackOrden.CancelarSeleccion(_mapper.Map<Comun.Modelo.Seleccion>(seleccion), motivo);
        }

        [HttpPut]
        /// <summary>
        /// Obtiene el estado actual de un pedido
        /// </summary>
        /// <param name="pedido"></param>
        public EstadoPreparacion ObtenerEstadoDePedido(Pedido pedido)
        {
            return _mapper.Map<EstadoPreparacion>(_servicioTrackOrden.ObtenerEstadoDePedido(_mapper.Map<Comun.Modelo.Pedido>(pedido)));
        }

        [HttpPut]
        /// <summary>
        /// Obtiene el estado actual de un seleccion
        /// </summary>
        /// <param name="seleccion"></param>
        public EstadoPreparacion ObtenerEstadoDeSeleccion(Seleccion seleccion)
        {
            {
                return _mapper.Map<EstadoPreparacion>(_servicioTrackOrden.ObtenerEstadoDeSeleccion(_mapper.Map<Comun.Modelo.Seleccion>(seleccion)));
            }
        }
    }
}
