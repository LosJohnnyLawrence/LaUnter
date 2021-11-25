using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Datos.Repo
{
    public class RepoMesa : RepoAbstracto, IRepoMesa
    {

        public RepoMesa(ContextoDatosUnter contextoDatosUnter):base(contextoDatosUnter)
        {
                
        }

        public EstadoMesa ObtenerEstadoMesa(string nombre) {
            return _contextoDatosUnter.EstadoMesas.FirstOrDefault(estado => estado.Nombre == nombre);
        }
       

        public Mesa ActualizarMesa(Mesa mesa)
        {
            return base.Actualizar(mesa);
        }

 

        public Mesa CrearMesa(Mesa mesa)
        {
            return base.Crear(mesa);
        }
   

        public Estadia CrearEstadia(Estadia estadia, Mesa mesa)
        {
            _contextoDatosUnter.Mesas.Update(mesa);
            return base.Crear(estadia);
        }

        public IQueryable<Mesa> ObtenerMesas() {
            return _contextoDatosUnter.Mesas.AsQueryable();
        }

        public Estadia ActualizarEstadia(Estadia estadia)
        {
            return base.Actualizar(estadia);
        }

        public void EliminarMesa(int mesaId)
        {
           var mesaAEliminar =  _contextoDatosUnter.Mesas.Find(mesaId);
            _contextoDatosUnter.Mesas.Remove(mesaAEliminar);
            _contextoDatosUnter.SaveChanges();

        }

        public Mesa ObtenerMesa(int mesaId)
        {
            return _contextoDatosUnter.Mesas.Find(mesaId);
        }
    }
}
