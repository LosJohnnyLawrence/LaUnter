﻿using AutoMapper;
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
    public class EstadoCancelado : EstadoAbstracto, IComportamientoEstadoPreparacion
    {
        public EstadoCancelado(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion, IRepoEstadoPreparacion repoEstadoPreparacion, IMapper mapper) : base(providerEstados, conectorNotificaion, repoEstadoPreparacion, mapper)
        {
        }

        public void AvanzarEstado()
        {
            return;
        }

        public void Cancelar()
        {
            return;
        }

        public void DevolverEstado()
        {
            base.ActualizarEstado((Constantes.EstadoPreparacion.TomandoPedido));
            _contextoEstado.SetComportamientoEstado(_providerEstados.ObtenerEstado(Constantes.EstadoPreparacion.TomandoPedido));
        }
            

        public override string ObtenerNombre()
        {
            return Constantes.EstadoPreparacion.Cancelado;
        }
    }
}
