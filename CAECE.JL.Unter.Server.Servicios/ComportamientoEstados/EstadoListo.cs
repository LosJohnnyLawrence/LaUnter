using CAECE.JL.Unter.Server.Comun;
using CAECE.JL.Unter.Server.Comun.Interfaces;
using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class EstadoListo : IComportamientoEstadoPreparacion
    {
        public void AsignarPreparacion(ContextoEstado contextoEstado)
        {
            throw new NotImplementedException();
        }

        public void AvanzarEstado()
        {
            throw new NotImplementedException();
        }

        public void DevolverEstado()
        {
            throw new NotImplementedException();
        }

        public void Notificar(string notificacion = null, object extras = null)
        {
            throw new NotImplementedException();
        }

        public string ObtenerNombre()
        {
            return Constantes.EstadoPreparacion.Listo;
        }
        public void Cancelar()
        {
            throw new NotImplementedException();
        }
    }
}
