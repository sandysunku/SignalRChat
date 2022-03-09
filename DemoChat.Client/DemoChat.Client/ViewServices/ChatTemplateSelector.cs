using DemoChat.Client.Models;
using DemoChat.Client.Views;
using Xamarin.Forms;

namespace DemoChat.Client.ViewServices
{
    public class ChatTemplateSelector : DataTemplateSelector
    {
        readonly DataTemplate _incomingDataTemplate;
        readonly DataTemplate _outgoingDataTemplate;

        public ChatTemplateSelector()
        {
            _incomingDataTemplate = new DataTemplate(typeof(IncomingView));
            _outgoingDataTemplate = new DataTemplate(typeof(OutgoingView));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var message = item as Message;
            if (message == null)
                return null;

            return (message.User == Constants.UserName) ? _outgoingDataTemplate : _incomingDataTemplate;
        }
    }
}
