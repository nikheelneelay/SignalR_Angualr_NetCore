using Microsoft.AspNetCore.SignalR;
using RealTimeCharts_Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.HubConfig
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(string data) => await Clients.All.SendAsync("broadcastchartdata", new Random().Next().ToString());
    }
}
