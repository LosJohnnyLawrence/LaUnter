using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace CAECE.JL.Unter.Notificaciones.Hubs
{
    public class HubNotificaciones : Hub
    {

            public async Task MandarNotificacion(string user, string message)
            {
                await Clients.All.SendAsync("ReceiveMessage", user, message);
            }
        }
    
}