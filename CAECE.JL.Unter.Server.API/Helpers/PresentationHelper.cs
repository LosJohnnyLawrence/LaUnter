using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Helpers
{
    public static class InyeccionPresentacionCore
    {

        public static void AgregarPerfilesPresAutomapper(this IServiceCollection servicios)
        {
            servicios.AddAutoMapper(typeof(PerfilMappingDTOs));

        }

    }
}
