using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Seleccion
    {
        public int Cantidad { get; set; }
        public Item Item { get; set; }
        public Item[] Agregar { get; set; }
        public Item[] Sacar { get; set; }
        public EstadoPedido Estado { get; set; }


    }
}
