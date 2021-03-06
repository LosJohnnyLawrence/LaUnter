using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Mesa
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int CantComensales { get; set; }
        public Sector Sector { get; set; }
        public EstadoMesa Estado { get; set; }
    }
}
