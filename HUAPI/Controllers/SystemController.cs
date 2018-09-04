using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Net.NetworkInformation;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// System controller.  These items are more about the API system.
    /// </summary>
    [Produces("application/json")]
    public class SystemController : Controller
    {
        private ILogger<SystemController> _logger;
        private IConfiguration _config;
        private ISettings _settings;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="config"></param>
        /// <param name="settings"></param>
        public SystemController(IConfiguration config, ISettings settings, ILogger<SystemController> logger)
        {
            _logger = logger;
            _config = config;
            _settings = settings;
        }

        /// <summary>
        /// Update a Setting in the database.  This is for live changing of settings, not the appsettings config file.
        /// </summary>
        /// <param name="setting">kvp</param>
        /// <returns>200 with message</returns>
        [HttpPost("api/v1/system/setting")]
        public IActionResult UpdateSetting([FromBody]CustomSetting setting)
        {
            //update instance
            var success = _settings.UpdateSetting(setting);
            if (success)
            {
                return Ok(new { Message = "Setting updated." });
            }
            return Ok(new { Message = "Setting not updated." });
        }

        /// <summary>
        /// A generic call to see if the server is reachable and alive.
        /// </summary>
        /// <returns>Successful message.</returns>
        [HttpGet("api/v1/system/ping")]
        [AllowAnonymous]
        public IActionResult Ping()
        {
            return Ok(new { Message = "Server is up." });
        }

        /// <summary>
        /// Ping an IP address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns>Message with results on success.</returns>
        [HttpGet("api/v1/system/ping/{address}")]
        public IActionResult PingAddress(string address)
        {
            Ping x = new Ping();
            PingReply reply = x.Send(System.Net.IPAddress.Parse(address));
            if (reply.Status == IPStatus.Success)
            {
                return Ok(new { Message = "Success", Output = System.Text.Encoding.UTF8.GetString(reply.Buffer) });
            }

            return Ok(new { Message = reply.Status.ToString() });
        }

        //[HttpGet("api/v1/system/jobs/init")]
        //public IActionResult SetupJobs()
        //{
        //    RecurringJob.AddOrUpdate(() => TestJob(), Cron.Daily);
        //    return Ok();
        //}

        public void TestJob()
        {
            _logger.LogInformation("*************************************");
        }

    }


}