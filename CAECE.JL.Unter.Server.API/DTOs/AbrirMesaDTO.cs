using CAECE.JL.Unter.Server.Comun.Modelo;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class AbrirMesaDTO
    {
        public Cliente Cliente { get; set; }
        public Mozo Mozo { get; set; }
        public int mesaId { get; set; }

    }
}