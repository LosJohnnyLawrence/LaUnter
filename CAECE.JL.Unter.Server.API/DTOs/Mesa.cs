using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class Mesa
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int CantComensales { get; set; }
        public Sector Sector { get; set; }
        public EstadoMesa Estado { get; set; }

    }
}
