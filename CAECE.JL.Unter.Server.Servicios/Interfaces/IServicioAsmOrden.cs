using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioAsmOrden
    {


        /// <summary>
        /// Crea un nuevo peido y perisiste su data, 
        /// devuelve el Id para operar con ella a que la PI es stateles
        /// </summary>
        /// <returns>Id del nuevo Pedido</returns>
        public int NuevoPedido();

        /// <summary>
        /// Añade un nuevo item al pedido ya seea Bebida,
        /// comida o promocion
        /// </summary>
        /// <param name="pedidoId">Id del pedido para operar</param>
        /// <param name="bebida">Bebida para agregar al pedido ya </param>
        /// <param name="seleccion">Describe como se modifica el plato base</param>
        public void AgregarBebida(int pedidoId, Bebida bebida, Seleccion seleccion);

        /// <summary>
        /// Añade un nuevo item al pedido ya seea Bebida,
        /// comida o promocion
        /// </summary>
        /// <param name="pedidoId">Id del pedido para operar</param>
        /// <param name="plato">Plato para agregar al pedido</param>
        /// <param name="seleccion">Describe como se modifica el plato base</param>
        public void AgregarPlato(int pedidoId, Plato plato, Seleccion seleccion);



        /// <summary>
        /// Devuelve el pedido ensamblado
        /// </summary>
        /// <param name="pedidoId">d del pedido para obetener</param>
        /// <returns>El pedido ensambaldo</returns>
        public Pedido ObtenerPedido(int pedidoId);
    }
}
