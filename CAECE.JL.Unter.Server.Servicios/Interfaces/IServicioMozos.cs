using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioMozos
    {

        public Mozo CrearNuevoMozo(Mozo mozo);
        public void BorrarMozo(Mozo mesa);
        public Mozo ActualizarDatosMozo(Mozo mozo);
        public TurnoMozo[] OtenerTurnosMozo(Mozo mozo);
        public TurnoMozo OtenerTurnosActualMozo(Mozo mozo);
        public TurnoMozo ActualizarTurnoMozo(TurnoMozo turno);
        public TurnoMozo CrearNuevoTurnoMozo(TurnoMozo turno);

   }
}
