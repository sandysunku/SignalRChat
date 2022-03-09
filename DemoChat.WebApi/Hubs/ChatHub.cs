using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DemoChat.WebApi.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userId, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", userId, message);
        }
    }
}
