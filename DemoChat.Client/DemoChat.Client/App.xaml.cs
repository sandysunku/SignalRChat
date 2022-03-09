using DemoChat.Client.Services;
using DemoChat.Client.ViewModel;
using DemoChat.Client.Views;
using Prism.Ioc;
using Prism.Unity;

namespace DemoChat.Client
{
    public partial class App : PrismApplication
    {
        public App()
        {
            InitializeComponent();

            MainPage = new JoinChatPage();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<JoinChatPage, JoinChatPageViewModel>();
            containerRegistry.RegisterForNavigation<ChatPage, ChatViewModel>();
            containerRegistry.RegisterSingleton<IHubService, HubService>();
        }

        protected override void OnInitialized()
        {
        }
    }
}
