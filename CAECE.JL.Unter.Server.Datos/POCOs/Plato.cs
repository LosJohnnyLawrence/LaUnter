using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Plato : Item
    {
        public Item[] PosiblesExtras { get; set; }
        public Categoria Categoria { get; set; }

        public RestriccionAlimentaria[] RestriccionesAlimentarias { get; set; }

    }
}
