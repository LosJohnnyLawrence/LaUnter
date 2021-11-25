using AutoMapper;
using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Datos.Interfaces;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class ServicioMenu : IServicioMenu
    {
        private readonly IRepoMenu _repoMenu;
        private readonly IMapper _mapper;

        public ServicioMenu(IRepoMenu repoMenu, IMapper mapper)
        {
            _repoMenu = repoMenu;
            _mapper = mapper;
        }

        ///  <inheritdoc/>
        public Bebida ActualizarBebida(Bebida bebida)
        {
            return  _mapper.Map<Bebida>( _repoMenu.ActualizarBebida(_mapper.Map<Datos.Bebida>( bebida)));
        }

        ///  <inheritdoc/>
        public Plato ActualizarPlato(Plato plato)
        {
            return _mapper.Map<Plato>(_repoMenu.ActualizarPlato(_mapper.Map<Datos.Plato>(plato)));
        }

        ///  <inheritdoc/>
        public Ingrediente ActualizarStockIngrediente(int ingredienteId, int valor)
        {
            return _mapper.Map<Ingrediente>(_repoMenu.ActualizarStockIngrediente(ingredienteId,valor));
        }

        ///  <inheritdoc/>
        public Bebida AgregarBebida(Bebida bebida)
        {
            return _mapper.Map<Bebida>(_repoMenu.AgregarBebida(_mapper.Map<Datos.Bebida>(bebida)));
        }

        ///  <inheritdoc/>
        public Ingrediente AgregarIngrediente(Ingrediente ingrediente)
        {
            return _mapper.Map<Ingrediente>(_repoMenu.AgregarIngrediente(_mapper.Map<Datos.Ingrediente>(ingrediente)));
        }

        ///  <inheritdoc/>
        public Plato AgregarPlato(Plato plato)
        {
            return _mapper.Map<Plato>(_repoMenu.AgregarPlato(_mapper.Map<Datos.Plato>(plato)));
        }

        ///  <inheritdoc/>
        public void BorrarItem(int itemId)
        {
            _repoMenu.BorrarItem(itemId);
        }

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IList<Bebida> ObtenerBebidas() {
            return _mapper.Map<IList<Bebida>>(_repoMenu.ObtenerBebidas()); 
        }

        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IList<Plato> ObtenerPlatos() {
            return _mapper.Map<IList<Plato>>(_repoMenu.ObtenerPlatos());
        }
        /// <summary>
        /// Obtiene list de ingredientes posible del menu
        /// </summary>
        /// <returns>Ingredientes del menu</returns>
        public IList<Ingrediente> ObtenerTodosLosIngredientes() {
            return _mapper.Map<IList<Ingrediente>>(_repoMenu.ObtenerTodosLosIngredientes());
        }


        /// <summary>
        /// Obtiene detalles de una bebida del menu
        /// </summary>
        /// <param name="itemId"> Id de la bebida la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Bebida ObtenerBebida(int itemId)
        {
            return _mapper.Map<Bebida>(_repoMenu.ObtenerBebida(itemId));
        }
    

        /// <summary>
        /// Obtiene detalles de un plato del menu
        /// </summary>
        /// <param name="itemId"> Id del plato la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Plato ObtenerPlato(int itemId)
        {
            return _mapper.Map<Plato>(_repoMenu.ObtenerPlato(itemId));
        }

        /// <summary>
        /// Obtiene detalles de un ingrediente posible del menu
        /// </summary>
        /// <param name="itemId"> Id del ingrediente la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Ingrediente ObtenerIngrediente(int itemId)
        {
            return _mapper.Map<Ingrediente>(_repoMenu.ObtenerIngrediente(itemId));
        }


    }
}
