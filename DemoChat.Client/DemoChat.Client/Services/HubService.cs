using System;
using Microsoft.AspNetCore.SignalR.Client;
using System.Threading.Tasks;

namespace DemoChat.Client.Services
{
    public class HubService : IHubService
    {
        private readonly HubConnection _hubConnection = null;
        private Action<string, string> receievMessage;

        public HubService()
        {
            _hubConnection = new HubConnectionBuilder().WithUrl(Constants.HubUrl).Build();
            _hubConnection.On<string, string>("ReceiveMessage",
                (userId, message) =>
                {
                    receievMessage(userId, message);
                });
        }

        public async Task Connect()
        {
            await _hubConnection.StartAsync();
        }
        public async Task SendMessage(string userId, string message)
        {
            await _hubConnection.SendAsync("SendMessage", userId, message);
        }

        public void RegisterForIncomingMessages(Action<string, string> action)
        {
            receievMessage = action;
        }
        public async Task Disconnect()
        {
            await _hubConnection.StopAsync();
        }
    }
}
