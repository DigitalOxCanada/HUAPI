using HUAPICore.Interfaces;
using HUAPICore.Services.Interfaces;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace HUAPICore.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class SMSTwilioService : SMSServiceBase, ISMSService
    {
        private readonly ISettings _settings;
        private IOptions<CustomConfig> _cfg { get; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="cfg"></param>
        public SMSTwilioService(ISettings settings, IOptions<CustomConfig> cfg) : base(cfg)
        {
            _settings = settings;
            _cfg = cfg;
        }

        /// <summary>
        /// Send a message using the Twilio api. If testmode is set then use testing values.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="message"></param>
        /// <param name="region"></param>
        /// <param name="when"></param>
        /// <returns></returns>
        public async Task SendMessage(string number, string message, string region, DateTime when)
        {
            // if not IsLive bail
            if (!Convert.ToBoolean(_settings.Settings["IsLive"]))
            {
                return;
            }

            number = CleanPhone(number);
            number = CheckTheTestMode(number);

            // Find your Account Sid and Token at twilio.com/console
            string accountSid = _cfg.Value.SystemConfig.SMSService.Twilio.AccountSid;
            string authToken = _cfg.Value.SystemConfig.SMSService.Twilio.AuthToken;

            TwilioClient.Init(accountSid, authToken);

            var msg = await MessageResource.CreateAsync(
                body: message,
                from: new PhoneNumber(_cfg.Value.SystemConfig.SMSService.Twilio.FromPhone),
                to: new PhoneNumber($"{number}")
            );
        }
    }
}
