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
    public class EstadoEntregado : EstadoAbstracto, IComportamientoEstadoPreparacion
    {
        public EstadoEntregado(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion, IRepoEstadoPreparacion repoEstadoPreparacion, IMapper mapper) : base(providerEstados, conectorNotificaion, repoEstadoPreparacion, mapper)
        {
        }

        public void AvanzarEstado()
        {
            return;
        }

        public void DevolverEstado()
        {
            base.ActualizarEstado((Constantes.EstadoPreparacion.Devolucion));
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Devolucion));
        }
        public void Cancelar()
        {
            base.ActualizarEstado((Constantes.EstadoPreparacion.Cancelado));
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Cancelado));
        }

       
        public override string ObtenerNombre()
        {
            return Constantes.EstadoPreparacion.Entregado;
        }
    }
}
