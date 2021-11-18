using CAECE.JL.Unter.Server.Comun;
using CAECE.JL.Unter.Server.Comun.Interfaces;
using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class EstadoEnPreparacion : EstadoAbstracto, IComportamientoEstadoPreparacion
    {
        public EstadoEnPreparacion(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion) : base(providerEstados, conectorNotificaion)
        {
        }

        public void AvanzarEstado()
        {
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Listo));
        }

        public void DevolverEstado()
        {
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.TomandoPedido));
        }

      
        public override string ObtenerNombre()
        {
            return Constantes.EstadoPreparacion.EnPreparacion;
        }

        public void Cancelar()
        {
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Cancelado));
        }
    }
}
