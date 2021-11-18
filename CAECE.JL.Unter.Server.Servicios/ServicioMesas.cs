using AutoMapper;
using CAECE.JL.Unter.Server.Comun;
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
    public class ServicioMesas : IServicioMesas
    {
        private readonly IRepoMesa _repoMesa;
        private readonly IRepoMozos _repoMozo;
        private readonly IMapper _mapper;

        public ServicioMesas(IRepoMesa repoMesa, IRepoMozos repoMozo, IMapper mapper)
        {
            _repoMesa = repoMesa;
            _repoMozo = repoMozo;
            _mapper = mapper;
        }

        ///  <inheritdoc/>
       public Estadia AbrirMesa(int mesaId, Cliente cliente, int mozoId)
        {

            var mesa = _repoMesa.ObtenerMesa(mesaId);
            var mozo = _repoMozo.ObtenerMozo(mozoId);
            var estadia = new Datos.Estadia() { Cliente = _mapper.Map<Datos.Cliente>(cliente), FechaInicio = DateTime.Now, Mozo = mozo, Mesa = mesa };          
            mesa.Estado = _repoMesa.ObtenerEstadoMesa(Constantes.EstadoMesa.Abierto);
            return _mapper.Map<Estadia>( _repoMesa.CrearEstadia(_mapper.Map<Datos.Estadia>(estadia), _mapper.Map<Datos.Mesa>(mesa)));
        }

        ///  <inheritdoc/>
        public Mesa ActualizarMesa(Mesa mesa)
        {
            return _mapper.Map<Mesa>(_repoMesa.ActualizarMesa(_mapper.Map<Datos.Mesa>(mesa)));
        }

        ///  <inheritdoc/>
        public void CerrarMesa(Mesa mesa)
        {
            mesa.Estado = _mapper.Map<EstadoMesa> (_repoMesa.ObtenerEstadoMesa(Constantes.EstadoMesa.Cerrado));
            _mapper.Map<Mesa>(_repoMesa.ActualizarMesa(_mapper.Map<Datos.Mesa>(mesa)));
        }

        ///  <inheritdoc/>
        public Mesa CrearMesa(Mesa mesa)
        {
            return _mapper.Map<Mesa>(_repoMesa.CrearMesa(_mapper.Map<Datos.Mesa>(mesa)));
        }

        ///  <inheritdoc/>
        public Mozo ObtenerMozo(Mesa mesa)
        {
            return _mapper.Map<Mozo>(_repoMozo.OtenerTurnoMozosActuales().FirstOrDefault(turno => turno.Sector.Id == mesa.Sector.Id).Mozo);
        }
    }
}
