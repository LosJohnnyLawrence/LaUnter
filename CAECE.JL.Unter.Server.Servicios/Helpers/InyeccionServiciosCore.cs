using CAECE.JL.Unter.Server.Servicios.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Helpers
{
    public static class InyeccionServiciosCore
    {
        /// <summary>
        /// Procedimiento que injecta los default con las implementacionciones default
        /// </summary>
        /// <param name="servicios"></param>
        public static void AgregarServiciosCore<TFact, TAsmOrd, TTrack, TMenu, TMesas, TMozos>(this IServiceCollection servicios)
            where TAsmOrd : class, IServicioAsmOrden where TFact : class, IServicioFacturacion where TTrack : class, IServicioTrackOrden
        where TMenu : class, IServicioMenu where TMesas : class, IServicioMesas where TMozos : class, IServicioMozos
        {


            servicios.AddTransient<IServicioAsmOrden, TAsmOrd>();
            servicios.AddTransient<IServicioFacturacion, TFact>();
            servicios.AddTransient<IServicioTrackOrden, TTrack>();
            servicios.AddTransient<IServicioMenu, TMenu>();
            servicios.AddTransient<IServicioMesas, TMesas>();
            servicios.AddTransient<IServicioMozos, TMozos>();

        }


        public void AgregarPerfilesAutomapper((this IServiceCollection servicios) { 
            --TODO
        }

        public void AgregarLogging(this IServiceCollection servicios)
        {
            servicios.AddLogging();--TODO
        }

    }
}
