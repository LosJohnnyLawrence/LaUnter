using CAECE.JL.Unter.Server.Comun.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Helpers
{
    /// <summary>
    /// Usa un service locator para usar estados estilo flyweight reutilizando las mismas instancias
    /// </summary>
    public class ProviderEstados : IProviderEstados
    {
        private readonly IDictionary<string, IComportamientoEstadoPreparacion> _lookupEstados = new Dictionary<string, IComportamientoEstadoPreparacion>();
        public IComportamientoEstadoPreparacion ObtenerEstado(string nombre)
        {
            if (_lookupEstados.TryGetValue(nombre, out var estado))
            {
                return estado;
            }
            return null;
        }

        public void RegistrarEstado<TEstado>() where TEstado : class, IComportamientoEstadoPreparacion
        {
            var nuevaInstaciaEstado = Activator.CreateInstance<TEstado>();
            _lookupEstados.Add(nuevaInstaciaEstado.ObtenerNombre(), nuevaInstaciaEstado);
        }
    }
}
