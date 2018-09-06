using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// EMR Patients controller
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    public class EMRPatientController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IProfileDAL _pfd;

        /// <summary>
        /// CTor
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
        /// Get all alerts from specified patient or all patients.
        /// </summary>
        /// <param name="ptntid">internal patient identifier or 0 for all</param>
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
        /// Check if demographics are valid
        /// </summary>
        /// <param name="ptntid">internal patient identifier</param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/checkaddress/{ptntid:long}")]
        public IActionResult IsDemographicsValid(long ptntid)
        {
            var k = _pfd.IsDemographicsValid(ptntid);

            return Ok(k);
        }

    }
}