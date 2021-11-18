using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Interfaces
{
    public interface IRepoOrden
    {
        /// <summary>
        /// Obtiene datos de un estadia particular que hubo en una mesa
        /// </summary>
        /// <param name="mesaId">Id de la mesa cuya data queremos obtener</param>
        /// <returns>Datos de la ultima etadia</returns>
        public Estadia ObtenerUltimaEstadia(int mesaId);

        /// <summary>
        /// Obtiene datos de pedidos recibidos por un mozo
        /// </summary>
        /// <param name="idDeMozo">Id del mozo relacionado a los datos a obtener</param>
        /// <param name="idEstado">Id si queremos filtrar por un estado particular</param>
        /// <returns>Array de datos de los pedidos</returns>
        public IQueryable<Pedido> ObtenerPedidosPorMozo(int idDeMozo, int? idEstado = null);


        /// <summary>
        /// Obtiene datos de pedidos por una mesa en particlar
        /// </summary>
        /// <param name="idDeMesa">Id de la mesa relacionado a los datos a obtener</param>
        /// <param name="idEstado">Id si queremos filtrar por un estado particular</param>
        /// <returns>Array de datos de los pedidos</returns>
        public IQueryable<Pedido> ObtenerPedidosPorMesa(int idDeMesa, int? idEstado = null);


        /// <summary>
        /// Persite un Pedido en la DB
        /// </summary>
        /// <param name="idDeMesa"></param>
        /// <returns></returns>
        public Pedido CrearUnPedido(Pedido idDeMesa);

        /// <summary>
        /// Permite Agregar un pedido solo menionando el Id
        /// </summary>
        /// <param name="selccion">Datos de la seleccion</param>
        /// <param name="idPedido">Id del pedido a actualizar</param>
        /// <returns>El pedido actualizado</returns>
        public Pedido AgregarSeleccionAPedido(Seleccion selccion, int idPedido);


        /// <summary>
        /// Actualiza un pedido
        /// </summary>
        /// <param name="pedido"> Datos del pedido actualizados </param>
        /// <returns>El pedido actualizado como esta en la DB</returns>
        public Pedido ActualizarPedido(Pedido pedido);


        /// <summary>
        /// Actualiza un seleccion
        /// </summary>
        /// <param name="seleccion"> Datos del seleccion actualizados </param>
        /// <returns>El seleccion actualizado como esta en la DB</returns>
        public Seleccion ActualizarSeleccion(Seleccion seleccion);



        /// <summary>
        /// Eliminar un pedido
        /// </summary>
        /// <param name="idPedido"> Id del pedido a borrar </param>
        public void EliminarPedido(int idPedido);

        /// <summary>
        /// Obtiene datos de un pedido particular que ya exista
        /// </summary>
        /// <param name="id">Id de la mesa  a obtener</param>
        /// <returns>Datos del pedido</returns>
        public Pedido ObtenerPedidoPorId(int id);

        /// <summary>
        /// Elimina una seeccion existente de un pedido
        /// </summary>
        /// <param name="selccionId"> Id de la seleccion actualizados </param>
        /// <returns>El pedido actualizado como esta en la DB</returns>
        public Pedido EliminarSeleccion(int selccionId);

    }
}
