using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace RealTimeServer.HubConfig
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(string data) => await Clients.All.SendAsync("broadcastchartdata", new Random().Next().ToString());
    }
}