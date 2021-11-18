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
        /// Avanza al proximo estado del flujo normal dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        public void PasarEstadoPedido(Pedido pedido);


        /// <summary>
        /// Retrocede a un estado de error dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void DevolverEstadoPedido(Pedido pedido, string motivo);



        /// <summary>
        /// Lleava al estado terminal de error "cancelado" 
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="pedido">pedido a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void CancelarPedido(Pedido pedido, string motivo);





        /// <summary>
        /// Avanza al proximo estado del flujo normal dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        public void PasarEstadoSeleccion(Seleccion seleccion);


        /// <summary>
        /// Retrocede a un estado de error dependiendo del estado actual
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void DevolverEstadoSeleccion(Seleccion seleccion, string motivo);



        /// <summary>
        /// Lleava al estado terminal de error "cancelado" 
        /// y aplicacciones necesarias
        /// </summary>
        /// <param name="seleccion">seleccion a operar</param>
        /// <param name="motivo">motivo para retroceder el estaso</param>
        public void CancelarSeleccion(Seleccion seleccion, string motivo);

        /// <summary>
        /// Obtiene el estado actual de un pedido
        /// </summary>
        /// <param name="pedido"></param>
        public EstadoPreparacion ObtenerEstadoDePedido(Pedido pedido);

        /// <summary>
        /// Obtiene el estado actual de un seleccion
        /// </summary>
        /// <param name="seleccion"></param>
        public EstadoPreparacion ObtenerEstadoDeSeleccion(Seleccion seleccion);

    }
}
