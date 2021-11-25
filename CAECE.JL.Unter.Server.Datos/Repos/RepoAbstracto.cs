using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    /// <summary>
    /// Implementacion de metodos geneicos a modo de template para evitar repetir codigos
    /// el patron repositorio seria implementado por las interfaces especificas y clases concretas
    /// </summary>
    public abstract class RepoAbstracto
    {
        protected readonly ContextoDatosUnter _contextoDatosUnter;

        public RepoAbstracto(ContextoDatosUnter contextoDatosUnter)
        {
            _contextoDatosUnter = contextoDatosUnter;

        }

        /// <summary>
        /// Metodo genrico para evitar repetir codigo boiler plate para crear un item
        /// </summary>
        /// <param name="datos"> Datos a insertar en el registro</param>
        /// <returns>Instancia con datos actuailzados del registro</returns>
        public T Crear<T>(T datos) where T : class
        {
            var nuevoRegistro = _contextoDatosUnter.Set<T>().Add(datos);
            _contextoDatosUnter.SaveChanges();
            return nuevoRegistro?.Entity;
        }

        public void Attach<T>(T prop) where T : class
        {
            if (prop != null)
            {
                _contextoDatosUnter.Set<T>().Attach(prop);
            }
        }
        public void AttachRange<T>(IEnumerable<T> prop) where T : class
        {
            if (prop != null)
            {
                _contextoDatosUnter.Set<T>().AttachRange(prop);
            }
        }
        public void AttachRange<T>(T[] prop) where T : class
        {
            if (prop != null)
            {
                _contextoDatosUnter.Set<T>().AttachRange(prop);
            }
        }

        /// <summary>
        /// Metodo genrico para evitar repetir codigo boiler plate para actualizar un item
        /// </summary>
        /// <param name="datos"> Datos a insertar en el registro</param>
        /// <returns>Instancia con datos actuailzados del registro</returns>
        public T Actualizar<T>(T datos) where T : class
        {
            var nuevoRegistro = _contextoDatosUnter.Set<T>().Update(datos);
            _contextoDatosUnter.SaveChanges();
            return nuevoRegistro?.Entity;
        }

        /// <summary>
        /// Metodo genrico para evitar repetir codigo boiler plate para eliminar un item
        /// </summary>
        /// <param name="datos"> Datos del registro a borrar</param>
        public void Borrar<T>(T datos) where T : class
        {
            _contextoDatosUnter.Set<T>().Remove(datos);
            _contextoDatosUnter.SaveChanges();
        }


    }
}
