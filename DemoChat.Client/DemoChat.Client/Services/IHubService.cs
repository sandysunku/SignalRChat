using System;
using System.Threading.Tasks;

namespace DemoChat.Client.Services
{
    public interface IHubService
    {
        Task SendMessage(string userId, string message);

        Task Connect();

        Task Disconnect();

        void RegisterForIncomingMessages(Action<string, string> action);
    }
}
