using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    public class RepoMozos : RepoAbstracto, IRepoMozos
    {
        public RepoMozos(ContextoDatosUnter contextoDatosUnter):base(contextoDatosUnter)
        {

        }
        public Mozo ActualizarDatosMozo(Mozo mozo)
        {
            return base.Actualizar(mozo);
        }

        public TurnoMozo ActualizarTurnoMozo(TurnoMozo turno)
        {
            return base.Actualizar(turno);
        }

        public void BorrarMozo(int idMozo)
        {
           var mozo = _contextoDatosUnter.Mozos.Find(idMozo);
            _contextoDatosUnter.Mozos.Remove(mozo);
        }

        public Mozo CrearNuevoMozo(Mozo mozo)
        {
            return base.Crear(mozo);
        }

        public TurnoMozo CrearNuevoTurnoMozo(TurnoMozo turno)
        {
            return base.Crear(turno);
        }

        public Mozo ObtenerMozo(int idMozo)
        {
           return  _contextoDatosUnter.Mozos.Find(idMozo);
        }

        public TurnoMozo OtenerTurnoActualMozo(int mozoId)
        {
            var diaActual = DateTime.Now.DayOfWeek;
            var horaActual = DateTime.Now.TimeOfDay;
            //obtngo un turno para este mozo particular dentro del dia y horarios actuales
           return _contextoDatosUnter.TurnoMozos.FirstOrDefault(turno => turno.Mozo.Id == mozoId &&
                                        turno.Dia == diaActual && horaActual < turno.FinTurno && horaActual > turno.InicioTurno);
        }

        public IQueryable<TurnoMozo> OtenerTurnoMozosActuales()
        {
            var diaActual = DateTime.Now.DayOfWeek;
            var horaActual = DateTime.Now.TimeOfDay;
            //obtngo un turno para este mozo particular dentro del dia y horarios actuales
            return _contextoDatosUnter.TurnoMozos.Where(turno => 
                                         turno.Dia == diaActual && horaActual < turno.FinTurno && horaActual > turno.InicioTurno);
        }

        public IQueryable<TurnoMozo> OtenerTurnosMozo(Mozo mozo)
        {
            return _contextoDatosUnter.TurnoMozos.Where(turno => turno.Mozo.Id == mozo.Id);

        }
    }
}
