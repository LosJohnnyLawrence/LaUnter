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
        /// devuelve el Id para operar con ella a que la API es stateles
        /// </summary>
        /// <param name="pedido">Datos peara crear nuevo pedido, datos del cliente, moxo y mesa son requeridos </param>
        /// <returns> Data nuevo Pedido</returns>
        public Pedido NuevoPedido(Pedido pedido);

  
        /// <summary>
        /// Añade un nuevo item al pedido ya seea Bebida,
        /// comida o promocion
        /// </summary>
        /// <param name="pedidoId">Id del pedido para operar</param>
        /// <param name="seleccion">Describe como se modifica el plato base</param>
        public Pedido AgregarSeleccion(int pedidoId, Seleccion seleccion);



        /// <summary>
        /// Elimina una seleccion de un pedido
        /// </summary>
        /// <param name="seleccionId">Id de la seleccion a eliminar</param>
        /// <returns>El nuevo estado del pedido</returns>
        public void EliminarSeleccion(int seleccionId);


        /// <summary>
        /// Devuelve el pedido ensamblado
        /// </summary>
        /// <param name="pedidoId">d del pedido para obetener</param>
        /// <returns>El pedido ensambaldo</returns>
        public Pedido ObtenerPedido(int pedidoId);

        /// Obtiene datos de todos los pedidos
        /// </summary>
        /// <returns>Array de datos de los pedidos</returns>
        public IList<Pedido> ObtenerPedidos();


        /// <summary>
        /// Obtiene  todos los estado
        /// </summary>
        /// <returns>Array de datos de los estados</returns>
        public IList<EstadoPreparacion> ObtenerEstados();
    }
}
