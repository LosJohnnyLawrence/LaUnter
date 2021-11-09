using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Interfaces
{
    public interface IRepoEstados
    {
        /// <summary>
        /// Obtiene datos de un estado particular que ya exista
        /// </summary>
        /// <param name="id">Id del estado</param>
        /// <returns>Datos del estado</returns>
        public EstadoPreparacion ObtenerEstado(int id);

        /// <summary>
        /// Obtiene datos de todos los estado ya existentes
        /// </summary>
        /// <returns>Array de Datos de estados</returns>
        public EstadoPreparacion[] ObtenerEstados();

        /// <summary>
        /// Obtiene datos de pedidos recibidos por un mozo
        /// </summary>
        /// <param name="estado">Datos nuevos del estaod</param>
        /// <returns>Estado final dele estado post actualizacion</returns>
        public EstadoPreparacion ActualizarEstado(EstadoPreparacion estado);  

    }
}
