using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Datos;
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
        private readonly RepoMenu _repoMenu;
        public ServicioMenu(RepoMenu repoMenu)
        {
            _repoMenu = repoMenu;
        }

        ///  <inheritdoc/>
        public Bebida ActualizarCatgoriaBebida(Bebida bebida)
        {
           _repoMenu.ActualizarCatgoriaBebida
        }

        ///  <inheritdoc/>
        public Plato ActualizarCatgoriaPlato(Plato plato)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Ingrediente ActualizarStockIngrediente(int ingredienteId, int valor)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Bebida AgregarBebida(Bebida bebida)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Ingrediente AgregarIngrediente(Ingrediente ingrediente)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public Plato AgregarPlato(Plato plato)
        {
            throw new NotImplementedException();
        }

        ///  <inheritdoc/>
        public void BorrarItem(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
