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
        private readonly IRepoPedidos _repoPedidos;
        private readonly IRepoItem _repoItem;

        public ServicioAsmOrden(IRepoPedidos repoPedidos, IRepoItem repoItem)
        {
            _repoPedidos = repoPedidos;
            _repoItem = repoItem;


        }

        public void AgregarIngredienteASeleccion(int pedidoId, Seleccion seleccion, Item componente)
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

        public Pedido SacarDeSeleccion(int pedidoId, Seleccion seleccion, Item componente)
        {
            throw new NotImplementedException();
        }
    }
}
