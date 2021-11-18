using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Interfaces
{
    public interface IRepoEstadoPreparacion
    {
        /// <summary>
        /// Obtiene datos de un estado particular que ya exista
        /// </summary>
        /// <param name="id">Id del estado</param>
        /// <returns>Datos del estado</returns>
        public EstadoPreparacion ObtenerEstado(int id);

        /// <summary>
        /// Persiste el motivo de un estado de excepcion, se toma el mayor nivel de detalle 
        /// si se pasan las selecciones ademas del pedido se asume que esto aplica a la seleccion en particular
        /// </summary>
        /// <param name="motivo">Comentario del motivo a paresistir</param>
        /// <param name="pedido">El pedido que puede haber cambiado de estado</param>
        /// <param name="seleccion">Las selecciones particulares que cambio de estado</param>        /// 
        public void PersistirMotivo(string motivo, Pedido pedido, Seleccion seleccion=null);

        /// <summary>
        /// Obtiene datos de todos los estado ya existentes
        /// </summary>
        /// <returns>Array de Datos de estados</returns>
        public IQueryable<EstadoPreparacion> ObtenerEstados();

        /// <summary>
        /// Obtiene datos de pedidos recibidos por un mozo
        /// </summary>
        /// <param name="estado">Datos nuevos del estaod</param>
        /// <returns>Estado final dele estado post actualizacion</returns>
        public EstadoPreparacion ActualizarEstado(EstadoPreparacion estado);  

    }
}
