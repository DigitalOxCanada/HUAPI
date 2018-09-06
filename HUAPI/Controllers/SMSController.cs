using HUAPIClassLibrary;
using HUAPICore.Filters;
using HUAPICore.Models;
using HUAPICore.Services;
using HUAPICore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// SMS texting controller
    /// </summary>
    [Produces("application/json")]
    public class SMSController : Controller
    {
        private readonly ISMSService _sms;
        private readonly IOptions<CustomConfig> _cfg;
        private readonly HUAPIDBContext _huapidbcontext;

        /// <summary>
        /// Ctor
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
        /// Send a text message using the configured SMS service.
        /// </summary>
        /// <param name="sms">SMSSendBody values</param>
        /// <returns></returns>
        [HttpPost("api/v1/[controller]/message")]
        [MustBeLiveFilter]
        public IActionResult SendText([FromBody]SMSSendBody sms)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _sms.SendMessage(sms.number, sms.message, sms.region, DateTime.Now);

            return NoContent();
        }

    }
}
