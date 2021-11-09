using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos
{
    public class RepoOrden : IRepoOrden
    {
        public Pedido EliminarSeleccion(Seleccion selccion)
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

        public Pedido ObtenerPedidoPorId(int id)
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
    }
}
