using Prism.Mvvm;
using Prism.Navigation;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoChat.Client.ViewModel
{
    public class JoinChatPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public string UserName { get; set; }

        public ICommand JoinChatCommand { get; set; }

        public JoinChatPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            JoinChatCommand = new Command(NavigateToChatPage);
        }

        private void NavigateToChatPage(object obj)
        {
            PersistUserName(UserName);
            _navigationService.NavigateAsync("ChatPage");
        }

        private static void PersistUserName(string userName)
        {
            Constants.UserName = userName;
        }
    }
}
