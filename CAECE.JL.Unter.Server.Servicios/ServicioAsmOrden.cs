using CAECE.JL.Unter.Server.Comun.Modelo;
using CAECE.JL.Unter.Server.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios
{
    public class ServicioAsmOrden : IServicioAsmOrden
    {
        public void AgregarBebida(int pedidoId, Bebida bebida, Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public void AgregarPlato(int pedidoId, Plato plato, Seleccion seleccion)
        {
            throw new NotImplementedException();
        }

        public int NuevoPedido()
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPedido(int pedidoId)
        {
            throw new NotImplementedException();
        }
    }
}
