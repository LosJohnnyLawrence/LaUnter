using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class Plato : Item
    {
     

        public IList<Item> PosiblesExtras { get; set; } = new List<Item>();
        public Categoria Categoria { get; set; }

        public RestriccionAlimentaria[] RestriccionesAlimentarias { get; set; }

        public override bool SePuedeAgregar(Item item) =>
           PosiblesExtras.Contains(item);

    }
}
