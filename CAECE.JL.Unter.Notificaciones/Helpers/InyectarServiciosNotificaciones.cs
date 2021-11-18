using CAECE.JL.Unter.Server.Comun.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Notificaciones.Helpers
{
    public static class InyectarServiciosNotificaciones
    {
        public static void AgregarServiciosNotificacion<TConnectorNoti>(this IServiceCollection servicios) where TConnectorNoti : class, IConectorNotificacion

        {
            servicios.AddTransient<IConectorNotificacion, TConnectorNoti>();
        }
    }
}
