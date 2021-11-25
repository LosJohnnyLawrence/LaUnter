using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class Pedido 
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Mesa Mesa { get; set; }
        public string Notas { get; set; }
        public IList<Seleccion> Selecciones { get; set; } = new List<Seleccion>();
        public Mozo Mozo { get; set; }
        public Cliente Cliente { get; set; }
        public EstadoPreparacion Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

    }
}
