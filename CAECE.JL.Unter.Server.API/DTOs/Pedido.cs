using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CAECE.JL.Unter.Server.Comun.Interfaces;

namespace CAECE.JL.Unter.Server.API.Controllers
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Mesa Mesa { get; set; }
        public string Notas { get; set; }
        public Seleccion[] Selecciones { get; set; }
        public Mozo Mozo { get; set; }
        public Cliente Cliente { get; set; }       
        public DateTime FechaInicio { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }

        private IComportamientoEstadoPreparacion _comportamientoEstadoPreparacion;
        public void SetComportamientoEstado(IComportamientoEstadoPreparacion comportamientoEstadoPreparacion) {
            _comportamientoEstadoPreparacion = comportamientoEstadoPreparacion;
        }
        public IComportamientoEstadoPreparacion GetComportamientoEstado()
        {
            return _comportamientoEstadoPreparacion;
        }
    }

}