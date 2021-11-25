using CAECE.JL.Unter.Server.Datos.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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
            base.Attach(pedido.Mesa);
            base.Attach(pedido.Mozo);
            base.Attach(pedido.Estado);
            base.Attach(pedido.Cliente);
            base.AttachRange(pedido.Selecciones);

            return base.Crear(pedido);
        }


        public void EliminarPedido(int idPedido)
        {
            var pedido = _contextoDatosUnter.Pedidos.Find(idPedido);
            _contextoDatosUnter.Pedidos.Remove(pedido);
            _contextoDatosUnter.SaveChanges();

        }

        public IQueryable<Pedido> ObtenerPedidos()
        {
            return _contextoDatosUnter.Pedidos.Include(p => p.Mozo).Include(p => p.Estado).Include(p => p.Cliente)
                .Include(p => p.Mesa).Include(p => p.Selecciones).AsQueryable();
        }
        

        public IQueryable<EstadoPreparacion> ObtenerEstados()
        {
            return _contextoDatosUnter.EstadosPreparacion.AsQueryable();
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
            return _contextoDatosUnter.Pedidos.Include(p => p.Mozo).Include(p => p.Estado).Include(p => p.Cliente)
                .Include(p => p.Mesa).Include(p => p.Selecciones).FirstOrDefault(p=>p.Id == id);
        }

        public IQueryable<Pedido> ObtenerPedidosPorMesa(int idDeMesa, int? idEstado = null)
        {
            //separo en dos sentencias de linq por eficiencia de armado de query
            if (idEstado == null)
            {
                return _contextoDatosUnter.Pedidos.Include(p => p.Mozo).Include(p => p.Estado).Include(p => p.Cliente)
                .Include(p => p.Mesa).Include(p => p.Selecciones).Where(pedido => pedido.Mesa.Id == idDeMesa);
            }
            return _contextoDatosUnter.Pedidos.Include(p => p.Mozo).Include(p => p.Estado).Include(p => p.Cliente)
                .Include(p => p.Mesa).Include(p => p.Selecciones).Where(pedido => pedido.Mesa.Id == idDeMesa && pedido.Estado.Id == idEstado);
        }

        public IQueryable<Pedido> ObtenerPedidosPorMozo(int idDeMozo, int? idEstado = null)
        {
            //separo en dos sentencias de linq por eficiencia de armado de query
            if (idEstado == null)
            {
                return _contextoDatosUnter.Pedidos.Include(p => p.Mozo).Include(p => p.Estado).Include(p => p.Cliente)
                .Include(p => p.Mesa).Include(p => p.Selecciones).Where(pedido => pedido.Mozo.Id == idDeMozo);
            }
            return _contextoDatosUnter.Pedidos.Include(p => p.Mozo).Include(p => p.Estado).Include(p => p.Cliente)
                .Include(p => p.Mesa).Include(p => p.Selecciones).Where(pedido => pedido.Mozo.Id == idDeMozo && pedido.Estado.Id == idEstado);
        }

        public Estadia ObtenerUltimaEstadia(int mesaId)
        {
            return _contextoDatosUnter.Estadias.Include(e=>e.Pedidos).Where(estadia => estadia.Mesa.Id == mesaId).OrderByDescending(estadia => estadia.FechaInicio).FirstOrDefault();
        }
    }
}
