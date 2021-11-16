using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    public class RepoEstadoPreparacion : IRepoEstadoPreparacion
    {
        public EstadoPreparacion ActualizarEstado(EstadoPreparacion estado)
        {
            throw new NotImplementedException();
        }

        public EstadoPreparacion ObtenerEstado(int id)
        {
            throw new NotImplementedException();
        }


        public IQueryable<EstadoPreparacion> ObtenerEstados()
        {
            throw new NotImplementedException();
        }
    }
}
