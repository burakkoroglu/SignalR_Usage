using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR.WEB.Hubs
{
    public class MyHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage" , message);
        }
    }
}
