using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun.Modelo
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public IList<Item> Componentes { get; protected set; } = new List<Item>();
        public  bool SePuedeAgregar(Item item) {
            return false;
        }
        public  bool SePuedeSacar(Item item) {
            return Componentes.Any(c => c.Id == item.Id);
        }

    }
}
