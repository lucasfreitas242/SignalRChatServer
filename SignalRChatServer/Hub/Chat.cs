using Microsoft.AspNetCore.SignalR;

namespace SignalRChatServer
{
    public class Chat : Hub 
    {
        public void NewMessage(string userName, string message)
        {
            Clients.All.SendAsync("newMessage", userName, message);
        }
    }
}
