using AutoMapper;
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
    [Route("api/mesa/[action]", Name = "[controller]_[action]")]
    [ApiController]
    public class ControladorMesa : Controller
    {
        private readonly IServicioMesas _servicioMesas;
        private readonly IMapper _mapper;

        public ControladorMesa(IServicioMesas servicioMesas, IMapper mapper)
        {
            _servicioMesas = servicioMesas;
            _mapper = mapper;
        }

        [HttpPost]
        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a crear</param>
        /// <returns>Mesa creada</returns>
        public Mesa CrearMesa(Mesa mesa) {
           return _mapper.Map<Mesa>( _servicioMesas.CrearMesa(_mapper.Map<Comun.Modelo.Mesa>(mesa)) );
        }


        [HttpGet]
        /// <summary>
        /// Nos dice los datos de una mesa en base a su id
        /// </summary>
        /// <param name="mesaId">Id de mesa cuyo mozo queremos saber</param>
        /// <returns>Datos de la mesa</returns>
        public Mesa ObtenerMesaPorId(int mesaId) {
            return _mapper.Map<Mesa>(_servicioMesas.ObtenerMesaPorId(mesaId));
        }

        [HttpPut]
        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a crear</param>
        /// <returns>Mesa creada</returns>
        public Mesa ActualizarMesa(Mesa mesa) {
            return _mapper.Map<Mesa>(_servicioMesas.ActualizarMesa(_mapper.Map<Comun.Modelo.Mesa>(mesa)));
        }

        [HttpGet]
        /// <summary>
        /// Nos dice el mozo asignado a una mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa cuyo mozo queremos saber</param>
        /// <returns>Mozo actal asignadoa a la mesa</returns>
        public Mozo ObtenerMozo(Mesa mesa) { 
            return _mapper.Map<Mozo>(_servicioMesas.ObtenerMozo(_mapper.Map<Comun.Modelo.Mesa>(mesa)));
        }


        [HttpPost]
        /// <summary>
        /// Cambia estado de mesa a abierto
        /// </summary>
        /// <param name="mesaId"> Datos de mesa a Abrir </param>
        /// <param name="cliente"> Cliente que va a estar en la mesa</param>
        /// <param name="mozoId"> Mozo principal ateniendo a la mesa en esta estadia</param>
        /// <returns></returns>
        public Estadia AbrirMesa(int mesaId, Cliente cliente, int mozoId) {
            return _mapper.Map<Estadia>(_servicioMesas.AbrirMesa(mesaId,_mapper.Map<Comun.Modelo.Cliente>(cliente), mozoId));
        }


        [HttpPost]
        /// <summary>
        /// Cambia estado de mesa a cerrado
        /// </summary>
        /// <param name="mesa">Datos de mesa a Cerrar</param>
        /// <returns>Mesa creada</returns>
        public void CerrarMesa(Mesa mesa) {
            _servicioMesas.CerrarMesa(_mapper.Map<Comun.Modelo.Mesa>(mesa)); }
    }
}
