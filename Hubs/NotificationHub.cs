using ERMTest.Data;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERMTest.Hubs
{
    public class NotificationHub : Hub
    {
        AppDbContext context;
        public NotificationHub(AppDbContext _context)
        {
            context = _context;
        }

        public async Task SendData(decimal freeOfMemory, decimal totalMemory, decimal usageCPU, decimal freeDisks, decimal totalDisks)
        {
            context.DataPK.Add(new DataPK
            {
                FreeOfMemory = freeOfMemory,
                TotalMemory = totalMemory,
                UsageCPU = usageCPU,
                FreeDisks = freeDisks,
                TotalDisks = totalDisks
            });
            await context.SaveChangesAsync();

            var ip = this.Context.GetHttpContext().Connection.LocalIpAddress;

            await this.Clients.All.SendAsync("NewData", freeOfMemory, totalMemory, usageCPU, freeDisks, totalDisks, ip.ToString());
        }

        public async Task ChangeDelay(int newDelay)
        {
            if(newDelay > 0)
                await this.Clients.All.SendAsync("NewDelay", newDelay);
        }
    }
}
