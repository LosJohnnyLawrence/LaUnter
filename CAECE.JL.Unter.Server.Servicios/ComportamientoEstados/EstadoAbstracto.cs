using AutoMapper;
using CAECE.JL.Unter.Server.Comun;
using CAECE.JL.Unter.Server.Comun.Interfaces;
using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public abstract class EstadoAbstracto
    {
        protected ContextoEstado _contextoEstado;
        protected IProviderEstados _providerEstados;
        protected IConectorNotificacion _conectorNotificacion;
        protected IRepoEstadoPreparacion _repoEstadoPreparacion;
        protected IMapper _mapper;


        public EstadoAbstracto(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion,
            IRepoEstadoPreparacion repoEstadoPreparacion, IMapper mapper)//TODO: terminar de implementar estados, datos migrados con seed y UI
        {
            _providerEstados = providerEstados;
            _conectorNotificacion = conectorNotificaion;
            _repoEstadoPreparacion = repoEstadoPreparacion;
            _mapper = mapper;
        }

        public virtual void Notificar(string notificacion = null, object extras = null)
        {
            _conectorNotificacion.EnviarNotificacion(notificacion ?? this.ObtenerNombre(), extras is string estraString ? estraString : (extras == null ? "" : System.Text.Json.JsonSerializer.Serialize(extras)));
        }

        public virtual void AsignarPreparacion(ContextoEstado contextoEstado)
        {
            _contextoEstado = contextoEstado;
        }

        public virtual void ActualizarEstado(string nombreEstado)
        {
            _contextoEstado.Estado = _mapper.Map<EstadoPreparacion>( _repoEstadoPreparacion.ObtenerEstados().FirstOrDefault(e => e.Nombre == nombreEstado));
        }

        public abstract string ObtenerNombre();
    }
}
