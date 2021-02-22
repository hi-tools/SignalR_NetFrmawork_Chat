using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.Hubs
{
    //public class ChatHub_Back : Hub
    //{
    //    public void Hello()
    //    {
    //        Clients.All.hello();
    //    }

    //    public void Send(string name, string message)
    //    {
    //        Clients.All.addNewMessageToPage(name, message);
    //    }

    //    public void Test(string message)
    //    {
    //        Clients.All.Test(message);
    //    }

    //    public void SendToUser(string user, string message)
    //    {
    //        //Context.User.Identity.Name;
    //        Clients.All.Test(message);
    //    }
    //}

    public class ChatHub : Hub<IChatHub>
    {
        public override Task OnConnected()
        {
            string ConnectionId = Context.ConnectionId;
            var username = Context.QueryString["username"];
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
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

        public void SendToUserPrivate(string name, string message, string connectionId)
        {
            Clients.All.SendToUserPrivate(name, message, connectionId);
        }
    }

    public interface IChatHub
    {
        void hello();
        void addNewMessageToPage(string name, string message);
        void Test(string message);
        void SendToUser(string user, string message);
        void SendToUserPrivate(string user, string message, string connectionId);


    }
}