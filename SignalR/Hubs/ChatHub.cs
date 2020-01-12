using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
        public void Test(string message)
        {
            Clients.All.Test(message);
        }

        public void SendToUser(string user, string message)
        {
            //Context.User.Identity.Name;
            Clients.All.Test(message);
        }
    }
}