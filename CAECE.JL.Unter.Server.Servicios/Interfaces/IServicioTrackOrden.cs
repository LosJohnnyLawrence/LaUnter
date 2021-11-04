using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Interfaces
{
    public interface IServicioTrackOrden
    {

        public void PonerPedidoEnProgreso(Pedido pedido);
        public void CompletarPedido(Pedido pedido);
        public void PedidoListoEntregar(Pedido pedido);
        public void DevolverPedido(Pedido pedido, string motivo);

        public void PonerSeleccionEnProgreso(Pedido pedido);
        public void CompletarSelecion(Pedido pedido);
        public void SeleccionListoEntregar(Pedido pedido);
        public void DevolverSeleccion(Pedido pedido, string motivo);


        public void ObtenerEstadoDepedido(Pedido pedido);


    }
}
