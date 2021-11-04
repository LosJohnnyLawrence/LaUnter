using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class ServicioTrackOrden : IServicioTrackOrden
    {
        public void CompletarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void CompletarSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public void DevolverPedido(Pedido pedido, string motivo)
        {
            throw new NotImplementedException();
        }

        public void DevolverSeleccion(Seleccion seleccion, string motivo)
        {
            throw new NotImplementedException();
        }

        public void ObtenerEstadoDePedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void ObtenerEstadoDeSeleccion(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public void PedidoListoEntregar(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void PonerPedidoEnProgreso(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void PonerSeleccionEnProgreso(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public void SeleccionListoEntregar(Seleccion seleccion)
        {
            throw new NotImplementedException();
        }
    }
}
