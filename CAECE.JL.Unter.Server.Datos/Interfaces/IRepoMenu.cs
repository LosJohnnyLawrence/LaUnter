using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Interfaces
{
    public interface IRepoMenu
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
        /// Actualiza el valor del stock de un Ingrediente dentreo
        /// de transacciones nativas del framework EF (Entity framework)
        /// </summary>
        /// <param name="ingredienteId">Id del ingrediente que queremos actualizar</param>
        /// <param name="valor">Nuevo Valor del stock</param>
        /// <returns>Ingrediente actualizado</returns>
        public Ingrediente ActualizarStockIngrediente(int ingredienteId, int valor);


        /// <summary>
        /// Actualiza el categoria de un Item en y sus componentes hijos, usando
        /// composite y transacciones nativas del framework EF (Entity framework)
        /// </summary>
        /// <param name="bebida">Item de la bebida a actualizar</param>
        /// <returns>Bebida actualizada</returns>
        public Bebida ActualizarBebida(Bebida bebida);

        /// <summary>
        /// Actualiza el categoria de un Item y sus componentes hijos, usando
        /// composite y transacciones nativas del framework EF (Entity framework)
        /// </summary>
        /// <param name="plato">Item del plato a actualizar</param>
        /// <returns>Bebida actualizada</returns>
        public Plato ActualizarPlato(Plato plato);


        /// <summary>
        /// Elimina un item del menu, ya sea un ingrediente, un plato o una bebida
        /// Se elimina en casacada y dentro de una transaccion
        /// </summary>
        /// <param name="itemId"></param>
        public void BorrarItem(int itemId);

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

        /// <summary>
        /// Obtiene list de ingredientes posible del menu
        /// </summary>
        /// <returns>Ingredientes del menu</returns>
        public IQueryable<Ingrediente> ObtenerTodosLosIngredientes();

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <param name="numPag">Numero de pagina</param>
        /// <param name="tamDePagina">Tmaño de pagina en cantidad de items</param>        /// 
        /// <returns>Lista con lazy loading del menu</returns>
        public IQueryable<Item> ObtenerMenuPaginado(int numPag, int tamDePagina);

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <param name="idCategoria">Id de la categoria que deseamos mostrar</param>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IQueryable<Item> ObtenerMenuPorCategoria(int idCategoria);

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de categorias de los Items Menu Existentes</returns>
        public IQueryable<Categoria> ObtenerCategorias();


        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IQueryable<Bebida> ObtenerBebidas();

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IQueryable<Plato> ObtenerPlatos();




    }
}
