using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun.Interfaces
{
    public interface IConectorNotificacion
    {
        public Task EnviarNotificacion(string nombre, string payload);
    }
}

