using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioTrackOrden
    {

        /// <summary>
        /// Cambia el estado del pedido a "activa"
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        public void PonerPedidoEnProgreso(Pedido pedido);

        /// <summary>
        /// Cambia el estado del pedido a "Completo"
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        public void CompletarPedido(Pedido pedido);

        /// <summary>
        /// Cambia el estado del pedido a "ParaEntregar"
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        public void PedidoListoEntregar(Pedido pedido);

        /// <summary>
        /// Cambia el estado del pedido a "Devuelto e incluye un motivo"
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        public void DevolverPedido(Pedido pedido, string motivo);

        /// <summary>
        /// Cambia el estado del seleccion a "activa"
        /// </summary>
        /// <param name="seleccion">pedido a operar</param>
        public void PonerSeleccionEnProgreso(Seleccion seleccion);

        /// <summary>
        /// Cambia el estado del seleccion a "Completo"
        /// </summary>
        /// <param name="seleccion">Seleccion a operar</param>
        public void CompletarSeleccion(Seleccion seleccion);

        /// <summary>
        /// Cambia el estado del seleccion a "ParaEntregar"
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        public void SeleccionListoEntregar(Seleccion seleccion);

        /// <summary>
        /// Cambia el estado del seleccion a "Devuelto e incluye un motivo"
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        public void DevolverSeleccion(Seleccion seleccion, string motivo);

        /// <summary>
        /// Obtiene el estado actual de un pedido
        /// </summary>
        /// <param name="pedido"></param>
        public void ObtenerEstadoDePedido(Pedido pedido);

        /// <summary>
        /// Obtiene el estado actual de un seleccion
        /// </summary>
        /// <param name="seleccion"></param>
        public void ObtenerEstadoDeSeleccion(Seleccion seleccion);

    }
}
