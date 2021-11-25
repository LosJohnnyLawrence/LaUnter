using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    /// <summary>
    /// Es un item del menu,
    /// puede ser un ingrediente de algo,
    /// un plato o una bebida
    /// </summary>
    public class Item
    {
        [JsonConstructorAttribute]
        public Item()
        {

        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public IList<Item> Componentes { get; protected set; } = new List<Item>();
        public virtual bool SePuedeAgregar(Item item) =>
             false;

        public virtual bool SePuedeSacar(Item item) =>
             Componentes.Any(c => c.Id == item.Id);

        public override bool Equals(object obj)
            => (obj is Item item) && item?.Id == this.Id;

        public virtual void SacarItemASeleccion(Item item, Seleccion seleccion)
        {
            if (SePuedeSacar(item))
                 seleccion.Sacar.Add(item);
            else
                throw new Exception("No se puede sacar");
        }

        public virtual void AgregarItemASeleccion(Item item, Seleccion seleccion)
        {
            if (SePuedeAgregar(item))
                seleccion.Agregar.Add(item);
            else
                throw new Exception("No se puede sacar");
        }



    }
}
