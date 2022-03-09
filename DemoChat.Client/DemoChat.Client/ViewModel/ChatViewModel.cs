using DemoChat.Client.Models;
using DemoChat.Client.Services;
using Prism.Mvvm;
using Prism.Navigation;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoChat.Client.ViewModel
{
    public class ChatViewModel : BindableBase, INavigationAware
    {
        private ObservableCollection<Message> _messages;
        private readonly IHubService _hubService;

        public ICommand SendTextCommand { get; set; }

        private string _chatText;

        public string ChatText
        {
            get => _chatText;
            set => SetProperty(ref _chatText, value);
        }

        public ObservableCollection<Message> Messages
        {
            get => _messages;
            set => SetProperty(ref _messages, value);
        }

        public ChatViewModel(IHubService hubService)
        {
            Messages = new ObservableCollection<Message>();
            _hubService = hubService;
            _hubService.RegisterForIncomingMessages(ReceievMessage);
            SendTextCommand = new Command(SendChatText);
        }

        private void ReceievMessage(string userId, string message)
        {
            Messages.Add(new Message { User = userId, Text = message });
        }

        private void SendChatText(object obj)
        {
            _hubService.SendMessage(Constants.UserName, ChatText);
            ChatText = string.Empty;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            _hubService.Disconnect();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            _hubService.Connect();

        }
    }
}
