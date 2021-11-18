using CAECE.JL.Unter.Server.Comun;
using CAECE.JL.Unter.Server.Comun.Interfaces;
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
            //Regitramos los estados apr aque sean faciles de ussar en los otros servicios
            var estadosProvider = new ProviderEstados();
                estadosProvider.RegistrarEstado<EstadoCancelado>();
                estadosProvider.RegistrarEstado<EstadoDevolucion>();
                estadosProvider.RegistrarEstado<EstadoEnPreparacion>();
                estadosProvider.RegistrarEstado<EstadoListo>();
                estadosProvider.RegistrarEstado<EstadoTomandoPedido>();
                estadosProvider.RegistrarEstado<EstadoEntregado>();
            servicios.AddTransient<IProviderEstados>(_ => estadosProvider);

        }


        public static void AgregarPerfilesNegocioAutomapper(this IServiceCollection servicios)
        {
            servicios.AddAutoMapper(typeof(PerfilDeMappingDesdeData));

        }



    }
}
