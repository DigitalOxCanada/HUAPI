using Microsoft.Extensions.Options;
using System.Text.RegularExpressions;

namespace HUAPICore.Services
{
    /// <summary>
    /// Base routines used for all SMS services
    /// </summary>
    public class SMSServiceBase
    {
        private readonly IOptions<CustomConfig> _cfg;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="cfg"></param>
        public SMSServiceBase(IOptions<CustomConfig> cfg)
        {
            _cfg = cfg;
        }

        /// <summary>
        /// If the TestMode is SendToTestPhone then use the test phone number instead of desired number.
        /// </summary>
        /// <param name="phone">Desired phone number</param>
        /// <returns>Test Phone number or supplied phone number</returns>
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
        /// <param name="phone">Desired phone number</param>
        /// <returns>phone number cleaned</returns>
        public string CleanPhone(string phone)
        {
            Regex digitsOnly = new Regex(@"[^\d]");
            string cleanPhoneNumber = digitsOnly.Replace(phone, "");
            if (!cleanPhoneNumber.StartsWith("1"))
            {
                cleanPhoneNumber = "1" + cleanPhoneNumber;
            }

            return cleanPhoneNumber;
        }


    }
}
