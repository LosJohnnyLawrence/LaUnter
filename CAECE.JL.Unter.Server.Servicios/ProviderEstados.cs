using AutoMapper;
using CAECE.JL.Unter.Server.Comun.Interfaces;
using CAECE.JL.Unter.Server.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Server.Servicios.Helpers
{
    /// <summary>
    /// Usa un service locator para usar estados estilo flyweight reutilizando las mismas instancias
    /// </summary>
    public class ProviderEstados : IProviderEstados
    {
        private readonly IDictionary<string, IComportamientoEstadoPreparacion> _lookupEstados = new Dictionary<string, IComportamientoEstadoPreparacion>();
        private readonly IProviderEstados _providerEstados;
        private readonly IConectorNotificacion _conectorNotificaion;
        private readonly IRepoEstadoPreparacion _repoEstadoPreparacion;
        private readonly IMapper _mapper;

        public ProviderEstados(IProviderEstados providerEstados, IConectorNotificacion conectorNotificaion,
            IRepoEstadoPreparacion repoEstadoPreparacion, IMapper mapper)
        {
         _providerEstados = providerEstados;
		_conectorNotificaion = conectorNotificaion;
		_repoEstadoPreparacion = repoEstadoPreparacion;
		_mapper = mapper;
        }
        public IComportamientoEstadoPreparacion ObtenerEstado(string nombre)
        {
            if (_lookupEstados.TryGetValue(nombre, out var estado))
            {
                return estado;
            }
            return null;
        }

        public void RegistrarEstado<TEstado>() where TEstado : class, IComportamientoEstadoPreparacion
        {
            var nuevaInstaciaEstado = (TEstado)Activator.CreateInstance(typeof(TEstado), _providerEstados, _conectorNotificaion,
                _repoEstadoPreparacion, _mapper);
            _lookupEstados.Add(nuevaInstaciaEstado.ObtenerNombre(), nuevaInstaciaEstado);
        }
    }
}
