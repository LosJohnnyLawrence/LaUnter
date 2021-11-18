using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    public class RepoOrden : RepoAbstracto, IRepoOrden
    {

        public RepoOrden(ContextoDatosUnter contextoDatosUnter) : base(contextoDatosUnter)
        {

        }


        public Pedido ActualizarPedido(Pedido pedido)
        {
            return base.Actualizar(pedido);
        }

        public Seleccion ActualizarSeleccion(Seleccion seleccion)
        {
            return base.Actualizar(seleccion);
        }

        public Pedido AgregarSeleccionAPedido(Seleccion selccion, int idPedido)
        {
            var pedido = _contextoDatosUnter.Pedidos.Find(idPedido);
            pedido.Selecciones.Append(selccion);
            _contextoDatosUnter.SaveChanges();
            return pedido;
        }

        public Pedido CrearUnPedido(Pedido pedido)
        {
            return base.Crear(pedido);
        }


        public void EliminarPedido(int idPedido)
        {
            var pedido = _contextoDatosUnter.Pedidos.Find(idPedido);
            _contextoDatosUnter.Pedidos.Remove(pedido);
            _contextoDatosUnter.SaveChanges();

        }

        public Pedido EliminarSeleccion(int selccionID)
        {
            var seleccion = _contextoDatosUnter.Selecciones.Find(selccionID);
            _contextoDatosUnter.Selecciones.Remove(seleccion);
            _contextoDatosUnter.SaveChanges();
            return _contextoDatosUnter.Pedidos.Find(seleccion.Pedido.Id);
        }

        public Pedido ObtenerPedidoPorId(int id)
        {
            return _contextoDatosUnter.Pedidos.Find(id);
        }

        public IQueryable<Pedido> ObtenerPedidosPorMesa(int idDeMesa, int? idEstado = null)
        {
            //separo en dos sentencias de linq por eficiencia de armado de query
            if (idEstado == null)
            {
                return _contextoDatosUnter.Pedidos.Where(pedido => pedido.Mesa.Id == idDeMesa);
            }
            return _contextoDatosUnter.Pedidos.Where(pedido => pedido.Mesa.Id == idDeMesa && pedido.Estado.Id == idEstado);
        }

        public IQueryable<Pedido> ObtenerPedidosPorMozo(int idDeMozo, int? idEstado = null)
        {
            //separo en dos sentencias de linq por eficiencia de armado de query
            if (idEstado == null)
            {
                return _contextoDatosUnter.Pedidos.Where(pedido => pedido.Mozo.Id == idDeMozo);
            }
            return _contextoDatosUnter.Pedidos.Where(pedido => pedido.Mozo.Id == idDeMozo && pedido.Estado.Id == idEstado);
        }

        public Estadia ObtenerUltimaEstadia(int mesaId)
        {
            return _contextoDatosUnter.Estadias.Where(estadia => estadia.Mesa.Id == mesaId).OrderByDescending(estadia => estadia.FechaInicio).FirstOrDefault();
        }
    }
}
