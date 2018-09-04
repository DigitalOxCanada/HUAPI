using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUAPICore.Services.Interfaces
{
    public interface ISMSService
    {
        Task SendMessage(string number, string message, string region, DateTime when);
    }
}
