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



    }
}
