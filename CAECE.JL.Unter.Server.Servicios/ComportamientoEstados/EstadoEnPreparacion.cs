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
    public class EstadoEnPreparacion : EstadoAbstracto, IComportamientoEstadoPreparacion
    {
        public EstadoEnPreparacion(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion, IRepoEstadoPreparacion repoEstadoPreparacion, IMapper mapper) : base(providerEstados, conectorNotificaion, repoEstadoPreparacion, mapper)
        {
        }

        public void AvanzarEstado()
        {
            base.ActualizarEstado((Constantes.EstadoPreparacion.Listo));
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Listo));
        }

        public void DevolverEstado()
        {
            base.ActualizarEstado((Constantes.EstadoPreparacion.TomandoPedido));
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.TomandoPedido));
        }

      
        public override string ObtenerNombre()
        {
            return Constantes.EstadoPreparacion.EnPreparacion;
        }

        public void Cancelar()
        {
            base.ActualizarEstado((Constantes.EstadoPreparacion.Cancelado));
            base._contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.Cancelado));
        }
    }
}
