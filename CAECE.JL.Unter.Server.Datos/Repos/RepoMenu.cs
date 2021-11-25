using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    public class RepoMenu : RepoAbstracto, IRepoMenu
    {

        public RepoMenu(ContextoDatosUnter contextoDatosUnter):base(contextoDatosUnter){}



        public Bebida ActualizarBebida(Bebida bebida)
        {
            return base.Actualizar(bebida);
        }

        public Plato ActualizarPlato(Plato plato)
        {
            return base.Actualizar(plato);
        }

        public Ingrediente ActualizarStockIngrediente(int ingredienteId, int valor)
        {
            var registroActual = _contextoDatosUnter.Ingredientes.Find(ingredienteId);
            registroActual.CantidadStock = valor;
            return base.Actualizar(registroActual);
        }

        public Bebida AgregarBebida(Bebida bebida)
        {
            base.Attach(bebida.Categoria);
            base.AttachRange(bebida.RestriccionesAlimentarias);
            base.AttachRange(bebida.Componentes);

            return base.Crear(bebida);
        }

        public Ingrediente AgregarIngrediente(Ingrediente ingrediente)
        {
            base.AttachRange(ingrediente.Componentes);

            return base.Crear(ingrediente);
        }

        public Plato AgregarPlato(Plato plato)
        {
            base.Attach(plato.Categoria);
            base.AttachRange(plato.RestriccionesAlimentarias);
            base.AttachRange(plato.PosiblesExtras);
            base.AttachRange(plato.Componentes);

            return base.Crear(plato);
        }

        public void BorrarItem(int itemId)
        {
            var registroActual = _contextoDatosUnter.ItemsMenu.Find(itemId);
            _contextoDatosUnter.ItemsMenu.Remove(registroActual);
            _contextoDatosUnter.SaveChanges();
        }

        public Bebida ObtenerBebida(int itemId)
        {
            return _contextoDatosUnter.Bebidas.Find(itemId);
        }

        public IQueryable<Categoria> ObtenerCategorias()
        {
            return _contextoDatosUnter.Categorias;
        }

        public Plato ObtenerIngrediente(int itemId)
        {
            return _contextoDatosUnter.Platos.Find(itemId);
        }

        public IQueryable<Item> ObtenerMenuPaginado(int numPag, int tamDePagina)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Item> ObtenerMenuPorCategoria(int idCategoria)
        {
            //obtiene los platos y lo castea a su tipo mas generico
            var platos = _contextoDatosUnter.Platos.Where(plato => plato.Categoria.Id == idCategoria).Cast<Item>();
            //obtiene las bebidas y lo castea a su tipo mas generico
            var bebidas = _contextoDatosUnter.Bebidas.Where(bebida => bebida.Categoria.Id == idCategoria).Cast<Item>();
            //junta todo y lo devuelve
            return platos.Union(bebidas);

        }

        public Plato ObtenerPlato(int itemId)
        {
            return _contextoDatosUnter.Platos.Find(itemId);
        }

        public IQueryable<Ingrediente> ObtenerTodosLosIngredientes()
        {
            return _contextoDatosUnter.Ingredientes;
        }
    }
}
