using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun.Modelo
{
    public class Bebida: Item
    {
        public Categoria Categoria { get; set; }

        public IList<RestriccionAlimentaria> RestriccionesAlimentarias { get; set; }

        
    }
}
