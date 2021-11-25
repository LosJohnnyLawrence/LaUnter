using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    public class RepoEstadoPreparacion : RepoAbstracto, IRepoEstadoPreparacion
    {
        public RepoEstadoPreparacion(ContextoDatosUnter contexto) : base(contexto)
        {

        }
        public EstadoPreparacion ActualizarEstado(EstadoPreparacion estado)
        {
            return base.Actualizar(estado);
        }

        public EstadoPreparacion ObtenerEstado(int id)
        {
            return _contextoDatosUnter.EstadosPreparacion.Find(id);
        }


        public IQueryable<EstadoPreparacion> ObtenerEstados()
        {
            return _contextoDatosUnter.EstadosPreparacion;
        }

        public void PersistirMotivo(string motivo, Pedido pedido, Seleccion seleccion = null)
        {
            base.Attach(seleccion);
            base.Attach(pedido);

            base.Crear(new MotivoDevolucion { Comentario = motivo, Pedido = pedido , Seleccion = seleccion});
        }
    }
}
