using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Estadia
    {
        [Key]
        public int Id { get; set; }
        public Mesa Mesa { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public DateTime Mozo { get; set; }
        public List<Pedido> Pedidos { get; set; }
    }
}
