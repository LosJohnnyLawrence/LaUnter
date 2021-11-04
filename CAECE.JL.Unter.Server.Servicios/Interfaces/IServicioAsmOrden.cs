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
        /// Añade un nuevo Ingrediente a la seleccion de un item en
        /// unpedido ya seea Bebida,
        /// comida o promocion
        /// </summary>
        /// <param name="pedidoId">Id del pedido para operar</param>
        // <param name="componente">Ingrediente a Agregar de la seleccion</param>
        /// <param name="seleccion">Seleccion de item actual</param>
        public void AgregarIngredienteASeleccion(int pedidoId, Seleccion seleccion, Item componente);

        /// <summary>
        /// Saca un nuevo Componenete a la seleccion de un item en
        /// unpedido ya seea Bebida,
        /// comida o promocion
        /// </summary>
        /// <param name="pedidoId">Id del pedido para operar</param>
        /// <param name="componente">Ingrediente a Sacar de la seleccion</param>
        /// <param name="seleccion">Seleccion de item actual</param>
        public Pedido SacarDeSeleccion(int pedidoId, Seleccion seleccion, Item componente);



        /// <summary>
        /// Devuelve el pedido ensamblado
        /// </summary>
        /// <param name="pedidoId">d del pedido para obetener</param>
        /// <returns>El pedido ensambaldo</returns>
        public Pedido ObtenerPedido(int pedidoId);
    }
}
