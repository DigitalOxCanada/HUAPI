using HUAPIClassLibrary;
using HUAPICore.Services;
using HUAPICore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    public class SMSController : Controller
    {
        private readonly ISMSService _sms;
        private readonly IOptions<CustomConfig> _cfg;
        private readonly HUAPIDBContext _huapidbcontext;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="huapidbcontext"></param>
        /// <param name="cfg"></param>
        /// <param name="sms"></param>
        public SMSController(HUAPIDBContext huapidbcontext, IOptions<CustomConfig> cfg, ISMSService sms)
        {
            _sms = sms;
            _cfg = cfg;
            _huapidbcontext = huapidbcontext;
        }

        /// <summary>
        /// 
        /// </summary>
        public class SMSSendBody
        {
            public string number { get; set; }
            public string message { get; set; }
            public string region { get; set; } = "Canada";
            public DateTime when { get; set; } = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sms"></param>
        /// <returns></returns>
        [HttpPost("api/v1/[controller]/message")]
        public IActionResult SendText([FromBody]SMSSendBody sms)
        {
            _sms.SendMessage(sms.number, sms.message, sms.region, DateTime.Now);

            return Ok();
        }

    }
}
