namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class MotivoDevolucion
    {
        public int Id { get; set; }
        public string Comentario { get; set; }
        public Pedido Pedido { get; set; }

    }
}