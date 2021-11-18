using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serilog;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    [Route("api/estados")]
    [ApiController]
    public class ControladorEstadosOrden : Controller
    {

        private readonly IServicioTrackOrden _servicioTrackOrden;
        //private readonly ILogger _servicioTrackOrden;


        public ControladorEstadosOrden(IServicioTrackOrden servicioTrackOrden)
        {
            throw new NotImplementedException();

        }
        [HttpPut]
        public IActionResult CompletarPedido(int pedidoId)
        {

            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult CompletarSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult DevolverPedido(Pedido pedido, string motivo)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult DevolverSeleccion(Seleccion seleccion, string motivo)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult ObtenerEstadoDePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult ObtenerEstadoDeSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult PedidoListoEntregar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult PonerPedidoEnProgreso(Pedido pedido)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult PonerSeleccionEnProgreso(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

       
        [HttpPut]
        public IActionResult SeleccionListoEntregar(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }
    }
}
