using CAECE.JL.Unter.Server.Comun;
using CAECE.JL.Unter.Server.Comun.Interfaces;
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

        public EstadoAbstracto(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion)//TODO: terminar de implementar estados, datos migrados con seed y UI
        {
            _providerEstados = providerEstados;
            _conectorNotificacion = conectorNotificaion;
        }

        public virtual void Notificar(string notificacion = null, object extras = null)
        {
            _conectorNotificacion.EnviarNotificacion(notificacion ?? this.ObtenerNombre(), extras is string estraString ? estraString : (extras == null ? "" : System.Text.Json.JsonSerializer.Serialize(extras)));
        }

        public virtual void AsignarPreparacion(ContextoEstado contextoEstado)
        {
            _contextoEstado = contextoEstado;
        }

        public abstract string ObtenerNombre();
    }
}
