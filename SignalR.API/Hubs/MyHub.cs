﻿using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalR.API.Hubs
{
    public class MyHub : Hub
    {
        public static List<string> Names = new List<string>();

        public async Task SendMessage(string name)
        {
            Names.Add(name);
            await Clients.All.SendAsync("ReceiveMessage", name);
        }


        public async Task GetNames()
        {
            await Clients.All.SendAsync("ReceiveNames", Names);
        }

    }
}