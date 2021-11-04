using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IEnsambladorPedido
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
        /// <param name="item">Item para agregar al pedido ya 
        /// seea Bebida, comida o promocion</param>
        public void AgregarItem(int pedidoId, Item item);

        /// <summary>
        /// Devuelve el pedido ensamblado
        /// </summary>
        /// <param name="pedidoId">d del pedido para obetener</param>
        /// <returns>El pedido ensambaldo</returns>
        public Pedido ObtenerPedido(int pedidoId);
    }
}
