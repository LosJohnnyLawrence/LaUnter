using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun.Modelo
{
    /// <summary>
    /// Es un componente de un pedido
    /// Una instania de un item con modificaciones
    /// </summary>
    public class Seleccion: ContextoEstado
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        public Item Item { get; set; }
        public IList<Item> Agregar { get; set; }
        public IList<Item> Sacar { get; set; }
        public Pedido Pedido { get; set; }     


    }
}
