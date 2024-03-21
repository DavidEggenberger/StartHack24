using Microsoft.AspNetCore.Identity;
using Server.Features.UserIdentity;
using Server.Features;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using System.Threading.Tasks;
using System;

namespace Server.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task NotifyNewStartup()
        {
            await Clients.All.SendAsync("NewStartup");
        }
    }
}
