using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    [Table("Plato")]
    public class Plato : Item
    {
        public IList<Item> PosiblesExtras { get; set; } = new List<Item>();
        public Categoria Categoria { get; set; }

        public RestriccionAlimentaria[] RestriccionesAlimentarias { get; set; }

    }
}
