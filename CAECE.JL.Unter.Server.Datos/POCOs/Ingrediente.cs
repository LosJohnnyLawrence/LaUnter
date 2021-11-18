using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    [Table("Ingrediente")]
    public class Ingrediente : Item
    {
        public decimal Costo { get; set; }
        public int CantidadStock { get; set; }

    }
}
