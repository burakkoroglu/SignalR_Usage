using Microsoft.AspNetCore.SignalR;
using SignalR.API.Models;
using System.Threading.Tasks;

namespace SignalR.API.Hubs
{
    public class ProductHub : Hub<IProductHub>
    {//strongly type hub
        public async Task SendProduct(Product product)
        {
            await Clients.All.ReceiveProduct(product);
        }
    }
}
