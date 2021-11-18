using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun.Interfaces
{
    /// <summary>
    /// Esta interfaz se usa para una implementacion modificada del patron de state
    /// De esta manera cada accion es la que no esperaria de su estado y si las notificaciones
    /// o acciones particuaares de cada estdo cambia no afecta al coportamiento d elos otros estados
    /// </summary>
    public interface IComportamientoEstadoPreparacion
    {

        /// <summary>
        /// Devuelve nombre del estado
        /// </summary>        
        public string ObtenerNombre();

        /// <summary>
        /// Cambia en el peidod el estado al siguiente en el flujo del camino feliz
        /// </summary>        
        public void AvanzarEstado();

        /// <summary>
        /// Pide que se vaya a un estado de los flujos alternativo de error
        /// </summary>
        public void DevolverEstado();

        /// <summary>
        ///Va al estado terminal de error
        /// </summary>
        public void Cancelar();

        /// <summary>
        /// Se ata la instancia del estado con un pedido o seleccion particular para poder operar
        /// </summary>
        /// <param name="contextoEstado">El pedido o seleccion al cual corresponde este estado</param>
        public void AsignarPreparacion(ContextoEstado contextoEstado);

        /// <summary>
        /// Genera una accion de notificaion
        /// el comportamiento de la notificaicon particular depende del estado e question
        /// </summary>
        /// <param name="notificacion"></param>
        /// <param name="extras"></param>
        public void Notificar(string notificacion = null, object extras = null);

    }
}
