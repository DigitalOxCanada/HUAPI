using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    public class EMRPatientController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IProfileDAL _pfd;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfd"></param>
        /// <param name="config"></param>
        public EMRPatientController(IProfileDAL pfd, IConfiguration config)
        {
            _config = config;
            _pfd = pfd;
        }

        /// <summary>
        /// Get a count of new clients since the date given.
        /// </summary>
        /// <param name="when">A date string or "now"</param>
        /// <returns>integer count</returns>
        [HttpGet("api/v1/[controller]/new/{when}")]
        public IActionResult NewClients(string when)
        {
            DateTime dt = DateTime.Today;
            if (when != "now")
            {
                dt = Convert.ToDateTime(when);
            }
            int cnt = _pfd.GetNewClientsCount(dt);

            return Ok(cnt);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptntid"></param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/alerts/{ptntid?}")]
        public IActionResult GetAlerts(long ptntid = 0)
        {
            var res = _pfd.GetAllAlerts(ptntid);
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ptntid"></param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/checkaddress/{ptntid:long}")]
        public IActionResult IsDemographicsValid(long ptntid)
        {
            var k = _pfd.IsDemographicsValid(ptntid);

            return Ok(k);
        }

    }
}