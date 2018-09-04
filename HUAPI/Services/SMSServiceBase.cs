using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HUAPICore.Services
{
    public class SMSServiceBase
    {
        private readonly IOptions<CustomConfig> _cfg;

        public SMSServiceBase(IOptions<CustomConfig> cfg)
        {
            _cfg = cfg;
        }

        public string CheckTheTestMode(string phone)
        {
            if (_cfg.Value.SystemConfig.SMSService.TestMode.Equals("SendToTestPhone"))
            {
                return _cfg.Value.SystemConfig.SMSService.TestPhone;
            }

            return phone;
        }

        /// <summary>
        /// Remove symbols from phone number
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public string CleanPhone(string phone)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            string cleanPhoneNumber = digitsOnly.Replace(phone, "");
            if (!cleanPhoneNumber.StartsWith("1"))
                cleanPhoneNumber = "1" + cleanPhoneNumber;

            return cleanPhoneNumber;
        }


    }
}
