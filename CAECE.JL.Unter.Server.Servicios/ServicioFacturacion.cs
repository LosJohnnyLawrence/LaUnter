using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class ServicioFacturacion : IServicioFacturacion
    {
        ///  <inheritdoc/>
        public void Facturar(Estadia estadia)
        {
           File.WriteAllText(System.Text.JSON)
        }
    }
}
