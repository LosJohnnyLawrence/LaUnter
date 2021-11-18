using System.ComponentModel.DataAnnotations;

namespace CAECE.JL.Unter.Server.Datos.Modelo
{
    public class MotivoDevolucion
    {
        [Key]
        public int Id { get; set; }
        public string Comentario { get; set; }
        public Pedido Pedido { get; set; }

    }

}