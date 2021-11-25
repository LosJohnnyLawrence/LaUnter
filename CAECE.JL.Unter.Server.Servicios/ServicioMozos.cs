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
    public class ServicioMozos : IServicioMozos
    {
        private readonly IRepoMozos _repoMozos;
        private readonly IMapper _mapper;

        public ServicioMozos(IRepoMozos repoMozos, IMapper mapper)
        {
            _repoMozos = repoMozos;
            _mapper = mapper;
        }
        ///  <inheritdoc/>
        public Mozo ActualizarDatosMozo(Mozo mozo)
        {
            return _mapper.Map<Mozo>(_repoMozos.ActualizarDatosMozo(_mapper.Map<Datos.Mozo>(mozo)));
        }

        ///  <inheritdoc/>
        public TurnoMozo ActualizarTurnoMozo(TurnoMozo turno)
        {
            return _mapper.Map<TurnoMozo>(_repoMozos.ActualizarTurnoMozo(_mapper.Map<Datos.TurnoMozo>(turno)));
        }


        ///  <inheritdoc/>
        public TurnoMozo ObtenerTurnoPorId(int idTurno) {
            return _mapper.Map<TurnoMozo>(_repoMozos.ObtenerTurnoPorId(idTurno));
        }

        ///  <inheritdoc/>
        public void BorrarMozo(int mozoId)
        {
            _repoMozos.BorrarMozo(mozoId);
        }

        ///  <inheritdoc/>
        public IList<Mozo> ObtenerMozos()
        {
            return _mapper.Map<IList<Mozo>>(_repoMozos.ObtenerMozos());
        }

        ///  <inheritdoc/>
        public Mozo ObtenerMozo(int idMozo)
        {
            return _mapper.Map<Mozo>(_repoMozos.ObtenerMozo(idMozo));
        }

        ///  <inheritdoc/>
        public Mozo CrearNuevoMozo(Mozo mozo)
        {
            return _mapper.Map<Mozo>(_repoMozos.CrearNuevoMozo(_mapper.Map<Datos.Mozo>(mozo)));
        }

        ///  <inheritdoc/>
        public TurnoMozo CrearNuevoTurnoMozo(TurnoMozo turno)
        {
            return _mapper.Map<TurnoMozo>(_repoMozos.CrearNuevoTurnoMozo(_mapper.Map<Datos.TurnoMozo>(turno)));
        }

        ///  <inheritdoc/>
        public TurnoMozo OtenerTurnoActualMozo(int mozoId)
        {
            return _mapper.Map<TurnoMozo>(_repoMozos.OtenerTurnoActualMozo(mozoId));
        }

        ///  <inheritdoc/>
        public IList<TurnoMozo> OtenerTurnosMozos()
        {
            return _mapper.Map<IList<TurnoMozo>>(_repoMozos.OtenerTurnoMozosActuales().ToList());
        }

        public IList<TurnoMozo> ObtenerTodosLosTurnos()
        {
            return _mapper.Map<IList<TurnoMozo>>(_repoMozos.ObtenerTodosLosTurnos());
        }
    }
}
