using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun
{
   public static class Constantes
    {
        public struct EstadoMesa {
            public const string Cerrado = "Cerrado";
            public const string Abierto = "Abierta";
        }

        public struct EstadoPreparacion
        {
            public const string Cancelado = "Cancelado";
            public const string Devolucion = "Devolucion";
            public const string EnPreparacion = "EnPreparacion";
            public const string Listo = "Listo";
            public const string TomandoPedido = "TomandoPedido";
            public const string Entregado = "Entregado";

        }

    }
}
