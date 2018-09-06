using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using HUAPICore.Services.Interfaces;
using Microsoft.Exchange.WebServices.Data;
using Microsoft.Extensions.Options;
using System;

namespace HUAPICore.Services
{
    /// <summary>
    /// SMS service using Microsoft Exchange service.
    /// </summary>
    public class SMSExchangeService : SMSServiceBase, ISMSService
    {

        private IOptions<CustomConfig> _cfg { get; }
        private readonly ISettings _settings;
        private readonly HUAPIDBContext _context;


        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="cfg"></param>
        public SMSExchangeService(IOptions<CustomConfig> cfg, HUAPIDBContext ctx, ISettings settings) : base(cfg)
        {
            _cfg = cfg;
            _context = ctx;
            _settings = settings;
        }

        /// <summary>
        /// Used by ExchangeService.AutodiscoverUrl to check if the url is SSL or not.
        /// </summary>
        /// <param name="url"></param>
        /// <returns>true or false</returns>
        static bool RedirectionCallback(string url)
        {
            // Return true if the URL is an HTTPS URL.
            return url.ToLower().StartsWith("https://");
        }

        /// <summary>
        /// Send a message using the ExchangeService api. If testmode is set then use testing values.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="message"></param>
        /// <param name="region"></param>
        /// <param name="when"></param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task SendMessage(string number, string message, string region, DateTime when)
        {
            // if not IsLive bail
            if (!Convert.ToBoolean(_settings.Settings["IsLive"]))
            {
                return;
            }

            number = CleanPhone(number);
            number = CheckTheTestMode(number);

            ExchangeService service = new ExchangeService();
            service.Credentials = new System.Net.NetworkCredential(_cfg.Value.SystemConfig.SMSService.Exchange.Email, _cfg.Value.SystemConfig.SMSService.Exchange.Pwd);
            service.AutodiscoverUrl(_cfg.Value.SystemConfig.SMSService.Exchange.Email, RedirectionCallback);

            EmailMessage messagebody = new EmailMessage(service);
            //messagebody.Subject = "my subject";
            messagebody.Body = message;
            messagebody.ToRecipients.Add($"{number}@txt.bell.ca"); //TODO go through the list of call carriers otherwise only works for users of this carrier.

            await messagebody.Save();
            await messagebody.Send();


        }

    }
}
