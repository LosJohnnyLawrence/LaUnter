using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Seleccion
    {
        [Key]
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public Item Item { get; set; }
        public IList<Item> Agregar { get; set; }
        public IList<Item> Sacar { get; set; }
        public EstadoPreparacion Estado { get; set; }
        public Pedido Pedido { get; set; }


    }
}
