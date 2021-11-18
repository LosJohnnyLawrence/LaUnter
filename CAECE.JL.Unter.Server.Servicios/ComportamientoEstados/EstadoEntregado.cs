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
    public class EstadoEntregado : EstadoAbstracto, IComportamientoEstadoPreparacion
    {
        public EstadoEntregado(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion) : base(providerEstados, conectorNotificaion)
        {
        }

        public void AvanzarEstado()
        {
            return;
        }

        public void DevolverEstado()
        {
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Devolucion));
        }
        public void Cancelar()
        {
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Cancelado));
        }

       
        public override string ObtenerNombre()
        {
            return Constantes.EstadoPreparacion.Entregado;
        }
    }
}
