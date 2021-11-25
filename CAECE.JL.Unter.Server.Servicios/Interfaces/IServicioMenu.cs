using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioMenu
    {
        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="ingrediente">data del ingredente nuevo a utilizaren el menu</param>
        /// <returns></returns>
        public Ingrediente AgregarIngrediente(Ingrediente ingrediente);

        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="plato">data del plato nuevo a agregar al menu</param>
        /// <returns>El nuevo plato con la data final</returns>
        public Plato AgregarPlato(Plato plato);

        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="bebida">data de la nueva bebida a agregar al menu</param>
        /// <returns>La nueva bebida con la data final</returns>
        public Bebida AgregarBebida(Bebida bebida);

        /// <summary>
        /// Actualiza el valor del stock de un Ingrediente
        /// </summary>
        /// <param name="ingredienteId">Id del ingrediente que queremos actualizar</param>
        /// <param name="valor"></param>
        /// <returns>Ingrediente actualizado</returns>
        public Ingrediente ActualizarStockIngrediente(int ingredienteId, int valor);


        /// <summary>
        /// Actualiza el categoria de una bebida
        /// </summary>
        /// <param name="bebida">Bebida a actualizar</param>
        /// <returns>Bebida actualizada</returns>
        public Bebida ActualizarBebida(Bebida bebida);

        /// <summary>
        /// Actualiza el categoria de un plato
        /// </summary>
        /// <param name="plato">Plato a actualizar</param>
        /// <returns>Plato ya actualizado</returns>
        public Plato ActualizarPlato(Plato plato);

        /// <summary>
        /// Elimina un item del menu, ya sea un ingrediente, un plato o una bebida
        /// </summary>
        /// <param name="itemId"></param>
        public void BorrarItem (int itemId);


        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IList<Bebida> ObtenerBebidas();

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IList<Plato> ObtenerPlatos();
        /// <summary>
        /// Obtiene list de ingredientes posible del menu
        /// </summary>
        /// <returns>Ingredientes del menu</returns>
        public IList<Ingrediente> ObtenerTodosLosIngredientes();

        /// <summary>
        /// Obtiene detalles de una bebida del menu
        /// </summary>
        /// <param name="itemId"> Id de la bebida la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Bebida ObtenerBebida(int itemId);

        /// <summary>
        /// Obtiene detalles de un plato del menu
        /// </summary>
        /// <param name="itemId"> Id del plato la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Plato ObtenerPlato(int itemId);

        /// <summary>
        /// Obtiene detalles de un ingrediente posible del menu
        /// </summary>
        /// <param name="itemId"> Id del ingrediente la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Ingrediente ObtenerIngrediente(int itemId);






    }
}
