using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    [Route("api/mesa")]
    [ApiController]
    public class ControladorMesa : Controller
    {
        private readonly IServicioMesas _servicioMesas;

        public ControladorMesa(IServicioMesas servicioMesas)
        {
            _servicioMesas = servicioMesas;
        }

        /// <summary>
        /// Inicia la transaccion de una estadia con datos del cliente y moso
        /// </summary>
        /// <param name="datosDeMesa"> datos de mesa a abrir</param>
        [HttpPost]
        public void AbrirMesa(AbrirMesaDTO datosDeMesa)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Actualiza los datos configurables de una mesa
        /// </summary>
        /// <param name="mesa"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult<MesaInformacionDTO> ActualizarMesa(CreateUpdateMesaDTO mesa)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Cierra una estadia en una mesa
        /// </summary>
        /// <param name="mesa"></param>
        [HttpPost]
        public ActionResult CerrarMesa(MesaQueryDTO mesa)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Crea una mesa nueva
        /// </summary>
        /// <param name="mesa"> data de la mesa a crear</param>
        /// <returns></returns>
        public ActionResult<MesaInformacionDTO> CrearMesa(CreateUpdateMesaDTO mesa)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtenmos el mozo que deberia estar asignado a una mesa ne prticular
        /// </summary>
        /// <param name="mesa"> Datos de la mesa en cuesion</param>
        /// <returns></returns>
        public ActionResult<MozoInfoDTO> ObtenerMozo(MesaQueryDTO mesa)
        {
            throw new NotImplementedException();
        }
    }
}
