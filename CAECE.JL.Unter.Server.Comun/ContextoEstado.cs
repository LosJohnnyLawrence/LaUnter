using CAECE.JL.Unter.Server.Comun.Interfaces;
using CAECE.JL.Unter.Server.Comun.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Comun
{
    public class ContextoEstado
    {
        public EstadoPreparacion Estado { get; set; }
        private IComportamientoEstadoPreparacion _comportamientoEstadoPreparacion;
        public void SetComportamientoEstado(IComportamientoEstadoPreparacion comportamientoEstadoPreparacion)
        {
            _comportamientoEstadoPreparacion = comportamientoEstadoPreparacion;
        }
        public IComportamientoEstadoPreparacion GetComportamientoEstado()
        {
            return _comportamientoEstadoPreparacion;
        }
    }
}
