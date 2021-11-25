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
    [Route("api/mozo/[action]", Name = "[controller]_[action]")]
    [ApiController]
    public class ControladorMozo : Controller
    {
        private readonly IServicioMozos _servicioMozos;
        private readonly IMapper _mapper;

        public ControladorMozo(IServicioMozos servicioMozos, IMapper mapper)
        {
            _servicioMozos = servicioMozos;
            _mapper = mapper;

        }

        [HttpGet]
        /// <summary>
        /// Obtiene la data de un mozo existente
        /// </summary>
        /// <param name="idMozo">id del mozo a buscar</param>
        public Mozo ObtenerMozo(int idMozo) {
            return _mapper.Map<Mozo>(_servicioMozos.ObtenerMozo(idMozo));
        }

        [HttpGet]
        /// <summary>
        /// Obtiene la data de los mozos existentes
        /// </summary>
        public IList<Mozo> ObtenerMozos() {
            return _mapper.Map<IList<Mozo>>(_servicioMozos.ObtenerMozos());
        }


        [HttpPost]
        /// <summary>
        /// Persiste la data de un nuevo mozo
        /// </summary>
        /// <param name="mozo">data del mozo</param>
        /// <returns>data final del mozo</returns>
        public Mozo CrearNuevoMozo(Mozo mozo) {
            return _mapper.Map<Mozo>( _servicioMozos.CrearNuevoMozo(_mapper.Map<Comun.Modelo.Mozo>(mozo)) );
        }

        [HttpDelete]
        /// <summary>
        /// Elimina la data de un mozo existente
        /// </summary>
        /// <param name="mozoId">data del mozo a borrar</param>
        public void BorrarMozo(int mozoId)
        {
            _servicioMozos.BorrarMozo(mozoId);
        }


        [HttpPut]
        /// <summary>
        /// Actualiza la data de un nuevo mozo
        /// </summary>
        /// <param name="mozo">data nueva del mozo</param>
        /// <returns>data actualizada del mozo</returns>
        public Mozo ActualizarDatosMozo(Mozo mozo)
        {
            return _mapper.Map<Mozo>(_servicioMozos.ActualizarDatosMozo(_mapper.Map<Comun.Modelo.Mozo>(mozo)));
        }


        [HttpGet]
        /// <summary>
        /// Obtiene Turnos de todos los mozos actuales
        /// </summary>
        /// <returns>Lista de turnos</returns>
        public IList<TurnoMozo> OtenerTurnosMozos()
        {
            return _mapper.Map<IList<TurnoMozo>>(_servicioMozos.OtenerTurnosMozos());
        }

        [HttpGet]
        /// <summary>
        /// Obtiene Turnos el turno qeudeberia hacer un mozo ahora
        /// </summary>
        /// <param name="mozoId">Data del mozo</param>
        /// <returns> Data del turno actual del mozo, si no es su turno,null</returns>
        public TurnoMozo OtenerTurnoActualMozo(int mozoId)
        {
            return _mapper.Map<TurnoMozo>(_servicioMozos.OtenerTurnoActualMozo(mozoId));
        }

        [HttpPut]
        /// <summary>
        /// Actualiza la data de un existente
        /// </summary>
        /// <param name="turno">data actualizada del turno</param>
        /// <returns>data actualizada del turno</returns>
        public TurnoMozo ActualizarTurnoMozo(TurnoMozo turno)
        {
            return _mapper.Map<TurnoMozo>(_servicioMozos.ActualizarTurnoMozo(_mapper.Map<Comun.Modelo.TurnoMozo>(turno)));
        }

        [HttpPost]
        /// <summary>
        /// Crea un nuevo turno par a un mozo
        /// </summary>
        /// <param name="turno">data del turno y del mozo</param>
        /// <returns>turno con data final</returns>
        public TurnoMozo CrearNuevoTurnoMozo(TurnoMozo turno)
        {
            return _mapper.Map<TurnoMozo>(_servicioMozos.CrearNuevoTurnoMozo(_mapper.Map<Comun.Modelo.TurnoMozo>(turno)));
        }


        [HttpGet]
        /// <summary>
        /// Obtiene la data de todos los turnos que exiten
        /// </summary>
        public IList<TurnoMozo> ObtenerTodosLosTurnos() {
            return _mapper.Map<IList<TurnoMozo>>(_servicioMozos.ObtenerTodosLosTurnos());
        }

    }
}
