using System.ComponentModel.DataAnnotations;

namespace CAECE.JL.Unter.Server.Datos
{
    /// <summary>
    /// Indica si es apro para alguna catergoria con restriccion alimentria:
    /// e.g. Vegano, Kosher
    /// </summary>
    public class RestriccionAlimentaria
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
    }
}