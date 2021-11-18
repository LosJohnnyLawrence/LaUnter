using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun.Interfaces
{
    /// <summary>
    /// Esta es una implementacion estilo service locator
    /// </summary>
    public interface IProviderEstados
    {
         /// <summary>
         /// Registra una clase de estado para poder encotrarla si unn consumidor la pie
         /// </summary>
         /// <typeparam name="TEstado">Clase concreta del estado</typeparam>
        public void RegistrarEstado<TEstado>() where TEstado: class, IComportamientoEstadoPreparacion;
        /// <summary>
        /// Devuelve una instancia de la clase si esta registrada
        /// </summary>
        /// <typeparam name="TEstado"></typeparam>
        /// <param name="nombre"></param>
        public IComportamientoEstadoPreparacion ObtenerEstado(string nombre);

    }
}
