using AutoMapper;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    [Route("api/menu/[action]", Name = "[controller]_[action]")]
    [ApiController]
    public class ControladorMenu : Controller
    {
        private readonly IServicioMenu _servicioMenu;
        private readonly IMapper _mapper;

        public ControladorMenu(IServicioMenu servicioMenu, IMapper mapper)
        {
            _servicioMenu = servicioMenu;
            _mapper = mapper;
        }

        [HttpPost]
        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="ingrediente">data del ingredente nuevo a utilizaren el menu</param>
        /// <returns></returns>
        public Ingrediente AgregarIngrediente(Ingrediente ingrediente) {
            return _mapper.Map<Ingrediente>(_servicioMenu.AgregarIngrediente(_mapper.Map<Comun.Modelo.Ingrediente>(ingrediente)));
        }

        [HttpPost]
        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="plato">data del plato nuevo a agregar al menu</param>
        /// <returns>El nuevo plato con la data final</returns>
        public Plato AgregarPlato(Plato plato)
        {
            return _mapper.Map<Plato>(_servicioMenu.AgregarPlato(_mapper.Map<Comun.Modelo.Plato>(plato)));
        }

        [HttpPost]
        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="bebida">data de la nueva bebida a agregar al menu</param>
        /// <returns>La nueva bebida con la data final</returns>
        public Bebida AgregarBebida(Bebida bebida)
        {
            return _mapper.Map<Bebida>(_servicioMenu.AgregarBebida(_mapper.Map<Comun.Modelo.Bebida>(bebida)));
        }

        [HttpPut]
        /// <summary>
        /// Actualiza el valor del stock de un Ingrediente
        /// </summary>
        /// <param name="ingredienteId">Id del ingrediente que queremos actualizar</param>
        /// <param name="valor"></param>
        /// <returns>Ingrediente actualizado</returns>
        public Ingrediente ActualizarStockIngrediente(int ingredienteId, int valor) {
            return _mapper.Map<Ingrediente>(_servicioMenu.ActualizarStockIngrediente(ingredienteId,valor));
        }


        [HttpPut]
        /// <summary>
        /// Actualiza el categoria de una bebida
        /// </summary>
        /// <param name="bebida">Bebida a actualizar</param>
        /// <returns>Bebida actualizada</returns>
        public Bebida ActualizarBebida(Bebida bebida) {
            return _mapper.Map<Bebida>(_servicioMenu.ActualizarBebida(_mapper.Map<Comun.Modelo.Bebida>(bebida))); 
        }

        [HttpPut]
        /// <summary>
        /// Actualiza el categoria de un plato
        /// </summary>
        /// <param name="plato">Plato a actualizar</param>
        /// <returns>Plato ya actualizado</returns>
        public Plato ActualizarPlato(Plato plato)
        {
            return _mapper.Map<Plato>(_servicioMenu.ActualizarPlato(_mapper.Map<Comun.Modelo.Plato>(plato)));
        }

        [HttpDelete]
        /// <summary>
        /// Elimina un item del menu, ya sea un ingrediente, un plato o una bebida
        /// </summary>
        /// <param name="itemId"></param>
        public void BorrarItem(int itemId) {
            _servicioMenu.BorrarItem(itemId);
        }



        [HttpGet]
        /// <summary>
        /// Agrega un nuevo ingrediente para usar en el menu
        /// </summary>
        /// <param name="ingrediente">data del ingredente nuevo a utilizaren el menu</param>
        /// <returns></returns>
        public Ingrediente ObtenerIngrediente(int ingredienteId)
        {
            return _mapper.Map<Ingrediente>(_servicioMenu.ObtenerIngrediente(ingredienteId));
        }

        [HttpGet]
        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IList<Bebida> ObtenerBebidas()
        {
            return _mapper.Map<IList<Bebida>>(_servicioMenu.ObtenerBebidas());
        }

        [HttpGet]
        /// <summary>
        /// Obtiene los platos y bebidas del menu con datos agregados y paginados
        /// </summary>
        /// <returns>Lista con lazy loading de items del menu elegido</returns>
        public IList<Plato> ObtenerPlatos()
        {
            return _mapper.Map<IList<Plato>>(_servicioMenu.ObtenerPlatos());
        }

        [HttpGet]
        /// <summary>
        /// Obtiene list de ingredientes posible del menu
        /// </summary>
        /// <returns>Ingredientes del menu</returns>
        public IList<Ingrediente> ObtenerTodosLosIngredientes()
        {
            return _mapper.Map<IList<Ingrediente>>(_servicioMenu.ObtenerTodosLosIngredientes());
        }

        [HttpGet]
        /// <summary>
        /// Obtiene detalles de una bebida del menu
        /// </summary>
        /// <param name="itemId"> Id de la bebida la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Bebida ObtenerBebida(int itemId)
        {
            return _mapper.Map<Bebida>(_servicioMenu.ObtenerBebida(itemId));
        }

        [HttpGet]
        /// <summary>
        /// Obtiene detalles de un plato del menu
        /// </summary>
        /// <param name="itemId"> Id del plato la cual deseamos obtener datos</param>
        /// <returns>Plato ya actualizado</returns>
        public Plato ObtenerPlato(int itemId)
        {
            return _mapper.Map<Plato>(_servicioMenu.ObtenerPlato(itemId));
        }

      



    }
}
