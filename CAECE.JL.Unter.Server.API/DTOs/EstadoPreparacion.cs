namespace CAECE.JL.Unter.Server.API.Controllers
{
    /// <summary>
    /// Es la data a persistir sobre un estado particular
    /// </summary>
    public class EstadoPreparacion
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
    }
}