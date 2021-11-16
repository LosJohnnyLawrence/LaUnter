using CAECE.JL.Unter.Notificaciones.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Notificaciones.Controllers
{
    public class EventosController : Controller
    {
        private readonly IHubContext<HubNotificaciones> _relevoNotificaciones;

        public EventosController(IHubContext<HubNotificaciones> relevoNotificaciones)
        {
            _relevoNotificaciones = relevoNotificaciones;
        }
        public async Task<IActionResult> CambioEstado(string mensaje)
        {
            await _relevoNotificaciones.Clients.All.SendAsync("CambioEstado", mensaje);
            return View();
        }
    }
}
