using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Interfaces
{
    public interface IRepoMozos
    {
        /// <summary>
        /// Persiste la data de un nuevo mozo
        /// </summary>
        /// <param name="mozo">data del mozo</param>
        /// <returns>data final del mozo</returns>
        public Mozo CrearNuevoMozo(Mozo mozo);

        /// <summary>
        /// Elimina la data de un mozo existente
        /// </summary>
        /// <param name="idMozo">id del mozo a borrar</param>
        public void BorrarMozo(int idMozo);

        /// <summary>
        /// Obtiene la data de un mozo existente
        /// </summary>
        /// <param name="idMozo">id del mozo a buscar</param>
        public Mozo ObtenerMozo(int idMozo);

        /// <summary>
        /// Obtiene la data de los mozos existentes
        /// </summary>
        public IQueryable<Mozo> ObtenerMozos();

        /// <summary>
        /// Actualiza la data de un nuevo mozo
        /// </summary>
        /// <param name="mozo">data nueva del mozo</param>
        /// <returns>data actualizada del mozo</returns>
        public Mozo ActualizarDatosMozo(Mozo mozo);

        /// <summary>
        /// Obtiene Turnos del mozo para saber
        /// cuadno y en que sector trabajaraa un mozo
        /// </summary>
        /// <param name="mozo"></param>
        /// <returns>Lista con lazy loading de turnos</returns>
        public IQueryable<TurnoMozo> OtenerTurnosMozo(Mozo mozo);

        /// <summary>
        /// Obtiene Turnos el turno qeudeberia hacer un mozo ahora
        /// </summary>
        /// <param name="mozoId">Data del mozo</param>
        /// <returns> Data del turno actual del mozo, si no es su turno,null</returns>
        public TurnoMozo OtenerTurnoActualMozo(int mozoId);

        /// <summary>
        /// Obtiene la data de un turno existente
        /// </summary>
        /// <param name="idTurno">id del truno a buscar</param>
        public TurnoMozo ObtenerTurnoPorId(int idTurno);

        /// <summary>
        /// Obtiene la data de todos los turnos que exiten
        /// </summary>
        public IQueryable<TurnoMozo> ObtenerTodosLosTurnos();


        /// <summary>
        /// Obtiene Turnos el turno de mozos actuales
        /// </summary>
        /// <returns> Data de turnos de mozos actuales con lazy laoding</returns>
        public IQueryable<TurnoMozo> OtenerTurnoMozosActuales();

        /// <summary>
        /// Actualiza la data de un existente
        /// </summary>
        /// <param name="turno">data actualizada del turno</param>
        /// <returns>data actualizada del turno</returns>
        public TurnoMozo ActualizarTurnoMozo(TurnoMozo turno);

        /// <summary>
        /// Crea un nuevo turno par a un mozo
        /// </summary>
        /// <param name="turno">data del turno y del mozo</param>
        /// <returns>turno con data final</returns>
        public TurnoMozo CrearNuevoTurnoMozo(TurnoMozo turno);


    }
}
