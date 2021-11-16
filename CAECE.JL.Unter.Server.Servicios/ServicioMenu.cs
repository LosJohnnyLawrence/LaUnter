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
    }
}
