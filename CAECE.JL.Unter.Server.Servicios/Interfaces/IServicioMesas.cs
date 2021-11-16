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
        /// Cambia estado de mesa a abierto
        /// </summary>
        /// <param name="mesaId"> Datos de mesa a Abrir </param>
        /// <param name="cliente"> Cliente que va a estar en la mesa</param>
        /// <param name="mozoId"> Mozo principal ateniendo a la mesa en esta estadia</param>
        /// <returns></returns>
        public Estadia AbrirMesa(int mesaId, Cliente cliente, int mozoId);


        /// <summary>
        /// Cambia estado de mesa a cerrado
        /// </summary>
        /// <param name="mesa">Datos de mesa a Cerrar</param>
        /// <returns>Mesa creada</returns>
        public void CerrarMesa(Mesa mesa);
    }
}
