using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Mozo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string DNI { get; set; }
        public DateTime FechaEntrada { get; set; }
    }
}
