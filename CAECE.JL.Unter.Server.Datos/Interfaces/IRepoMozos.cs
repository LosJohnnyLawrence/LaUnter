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
        /// <param name="mozo">Data del mozo</param>
        /// <returns> Data del turno actual del mozo, si no es su turno,null</returns>
        public TurnoMozo OtenerTurnoActualMozo(Mozo mozo);

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
