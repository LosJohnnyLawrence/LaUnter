using CAECE.JL.Unter.Server.Datos.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Helpers
{
    public static class InyeccionDatosCore
    {
        /// <summary>
        /// Procedimiento que injecta los default con las implementacionciones default
        /// </summary>
        /// <param name="servicios"></param>
        public static void AgregarReposCore<TEstados, TMenu, TMesa, TMozos, TOrden>(this IServiceCollection servicios)
            where TEstados : class, IRepoEstadoPreparacion where TMenu : class, IRepoMenu where TMesa : class, IRepoMesa
        where TMozos : class, IRepoMozos where TOrden : class, IRepoOrden 
        {
             
                servicios.AddTransient<IRepoEstadoPreparacion, TEstados>(); 
                servicios.AddTransient<IRepoMenu, TMenu>(); 
                servicios.AddTransient<IRepoMesa, TMesa>();        
                servicios.AddTransient<IRepoMozos, TMozos>(); 
                servicios.AddTransient<IRepoOrden, TOrden>();

    }  

    }
}
