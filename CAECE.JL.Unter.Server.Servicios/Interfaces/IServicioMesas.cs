using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioMesas
    {
        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a crear</param>
        /// <returns>Mesa creada</returns>
        public Mesa CrearMesa(Mesa mesa);

        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a crear</param>
        /// <returns>Mesa creada</returns>
        public Mesa ActualizarMesa(Mesa mesa);

        /// <summary>
        /// Nos dice el mozo asignado a una mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa cuyo mozo queremos saber</param>
        /// <returns>Mozo actal asignadoa a la mesa</returns>
        public Mozo ObtenerMozo(Mesa mesa);


        /// <summary>
        /// Crea una nueva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a Abrir</param>
        /// <returns>Mesa creada</returns>
        public void AbrirMesa(Mesa mesa);


        /// <summary>
        /// Crea una neuva mesa
        /// </summary>
        /// <param name="mesa">Datos de mesa a Cerrar</param>
        /// <returns>Mesa creada</returns>
        public void CerrarMesa(Mesa mesa);
    }
}
