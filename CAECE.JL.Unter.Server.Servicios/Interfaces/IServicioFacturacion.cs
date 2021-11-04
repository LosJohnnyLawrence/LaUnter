using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioFacturacion
    {
        /// <summary>
        /// Aplica un procedimiento definido en la clase implementda para 
        /// emitir una accion que usa los datos de la estadia d eun cliente en una mesa
        /// para facturar
        /// </summary>
        /// <param name="estadia"></param>
        public void Facturar(Estadia estadia);
    }
}
