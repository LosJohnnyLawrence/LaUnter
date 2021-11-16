using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Interfaces
{
    public interface IRepoMesa
    {
        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a crear</param>
        /// <returns>Mesa creada</returns>
        public Mesa CrearMesa(Mesa mesa);


        /// <summary>
        /// Obtiene el id de un estado en base a su nombre
        /// </summary>
        /// <param name="nombre"> nombre del estado a buscar</param>
        /// <returns>Estado posible de una mesa</returns>
        public EstadoMesa ObtenerEstadoMesa(string nombre);


        /// <summary>
        /// Crea una nueva estadia
        /// </summary>
        /// <param name="estadia">Datos de la estadia a crear</param>
        /// <param name="mesa">Datos de la mesa de la estadia</param>
        /// 
        /// <returns>Estadia creada</returns>
        public Estadia CrearEstadia(Estadia estadia, Mesa mesa);

        /// <summary>
        /// Actualiza una estadia existente
        /// </summary>
        /// <param name="estadia">Nuevos Datos de la estadia a actualizar</param>
        /// <returns>Estadia Actualizada</returns>
        public Estadia ActualizarEstadia(Estadia estadia);

        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a crear</param>
        /// <returns>Mesa creada</returns>
        public Mesa ActualizarMesa(Mesa mesa);

        /// <summary>
        /// Obtienedatos de una mesa
        /// </summary>
        /// <param name="mesaId">Datos de mesa a obtener</param>
        /// <returns>Mesa obtenida</returns>
        public Mesa ObtenerMesa(int mesaId);


        /// <summary>
        /// Elimina una mesa
        /// </summary>
        /// <param name="mesaId">Datos de mesa a eliminar</param>
        /// <returns>Mesa creada</returns>
        public void EliminarMesa(int mesaId);


    }
}
