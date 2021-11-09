using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class RepoMesa : IRepoMesa
    {
        public Pedido ActualizarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido AgregarSeleccionAPedido(Seleccion selccion, int idPedido)
        {
            throw new NotImplementedException();
        }

        public Pedido CrearUnPedido(Pedido idDeMesa)
        {
            throw new NotImplementedException();
        }

        public void EliminarPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public void EliminarPedido(int idPedido)
        {
            throw new NotImplementedException();
        }

        public Pedido[] ObtenerPedidosPorMesa(int idDeMesa, int? idEstado = null)
        {
            throw new NotImplementedException();
        }

        public Pedido[] ObtenerPedidosPorMozo(int idDeMozo, int? idEstado = null)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerUltimaEstadia(int mesaId)
        {
            throw new NotImplementedException();
        }
    }
}
