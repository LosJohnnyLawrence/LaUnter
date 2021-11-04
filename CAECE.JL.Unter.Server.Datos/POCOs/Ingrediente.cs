using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Ingrediente : Item
    {
        public decimal Costo { get; set; }
        public int CantidadStock { get; set; }

    }
}
