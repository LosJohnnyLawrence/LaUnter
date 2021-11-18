using CAECE.JL.Unter.Notificaciones.Helpers;
using CAECE.JL.Unter.Server.Comun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Notificaciones
{
    public class ConectorNotificacion : IConectorNotificacion
    {
        public Task EnviarNotificacion(string nombre, string payload)
        {
            throw new NotImplementedException();
        }
    }
}
