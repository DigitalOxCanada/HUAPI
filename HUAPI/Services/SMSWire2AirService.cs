using HUAPICore.Interfaces;
using HUAPICore.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace HUAPICore.Services
{
    /// <summary>
    /// SMS service for the Wire2Air API in the cloud
    /// </summary>
    public class SMSWire2AirService : SMSServiceBase, ISMSService
    {
        private readonly ISettings _settings;
        private IOptions<CustomConfig> _cfg { get; }

        static HttpClient client = new HttpClient();

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="cfg"></param>
        public SMSWire2AirService(ISettings settings, IOptions<CustomConfig> cfg) : base(cfg)
        {
            _settings = settings;
            _cfg = cfg;
        }

        /// <summary>
        /// Send a message using the Wire2Air api. If testmode is set then use testing values.
        /// </summary>
        /// <param name="number">phone number</param>
        /// <param name="message">short string to send</param>
        /// <param name="region"></param>
        /// <param name="when"></param>
        /// <returns>Task</returns>
        public async Task SendMessage(string number, string message, string region, DateTime when)
        {
            // if not IsLive bail
            if (!Convert.ToBoolean(_settings.Settings["IsLive"]))
            {
                return;
            }

            number = CleanPhone(number);
            number = CheckTheTestMode(number);

            string serviceUrl = _cfg.Value.SystemConfig.SMSService.Wire2Air.ServiceUrl;

            //if we are not in TEST mode then send the real message to the sms service.
            serviceUrl = SmartFormat.Smart.Format(serviceUrl, new { TO = number, MSG = HttpUtility.UrlEncode(message) });
            HttpResponseMessage response = await client.PostAsync(serviceUrl, null);
            response.EnsureSuccessStatusCode();
        }

    }
}