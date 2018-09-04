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
    public class EMRUserController : ControllerBase
    {
        private readonly IProfileDAL _pfd;
        private readonly IConfiguration _config;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfd"></param>
        /// <param name="config"></param>
        public EMRUserController(IProfileDAL pfd, IConfiguration config)
        {
            _pfd = pfd;
            _config = config;
        }

        /// <summary>
        /// Get user object by email address.
        /// </summary>
        /// <param name="email">Full email address of the user.</param>
        /// <returns>No Context or PPPU object</returns>
        [HttpGet("api/v1/[controller]/byemail/{email}")]
        public IActionResult GetUserByEmail(string email)
        {
            var res = _pfd.GetUserByEmail(email);
            if(res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        /// <summary>
        /// Get user object by usercode.
        /// </summary>
        /// <param name="usercode">The user code that is used to log in with.</param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/bycode/{usercode}")]
        public IActionResult GetUserByCode(string usercode)
        {
            var res = _pfd.GetUserByCode(usercode);
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        /// <summary>
        /// Sets the enabled flag on the user record that matches the usercode.
        /// </summary>
        /// <param name="usercode">The user code that is used to log in with.</param>
        /// <returns></returns>
        [HttpPost("api/v1/[controller]/enable/{usercode}")]
        public IActionResult EnableUser(string usercode)
        {
            int cnt = _pfd.EnableUser(usercode);
            if (cnt == 0)
            {
                return NotFound();
            }

            return Ok(new { Message = $"Updated {cnt} records." });
        }

        /// <summary>
        /// Disables the user that matches the usercode.
        /// </summary>
        /// <param name="usercode">The user code that is used to log in with.</param>
        /// <returns></returns>
        [HttpPost("api/v1/[controller]/disable/{usercode}")]
        public IActionResult DisableUser(string usercode)
        {
            int cnt = _pfd.DisableUser(usercode);
            if (cnt == 0)
            {
                return NotFound();
            }

            return Ok(new { Message = $"Updated {cnt} records." });
        }

        /// <summary>
        /// Get the logged in information of the user matching the PPPU id. 
        /// </summary>
        /// <param name="pppuid">Internal ID on the PPPU table of the user.</param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/loggedininfo/{pppuid}")]
        public IActionResult GetUserLoggedInInfo(long pppuid)
        {
            var res = _pfd.GetUserLoggedInInfo(pppuid);
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        /// <summary>
        /// Get the latest counts of concurrent users.
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/concurrent/latest")]
        public IActionResult GetConcurrentUsersLatest()
        {
            var res = _pfd.GetConcurrentUsersLatest();
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

        /// <summary>
        /// Get a dataset of values of concurrent users of the date specified.  
        /// </summary>
        /// <param name="date">A date string or "today" to always get the current.</param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/concurrent/{date}")]
        public IActionResult GetConcurrentUsers(string date)
        {
            DateTime dt = DateTime.Today;
            if (date != "today")
            {
                dt = Convert.ToDateTime(date);
            }

            var res = _pfd.GetConcurrentUsers(dt);
            if (res == null)
            {
                return NotFound();
            }

            return Ok(res);
        }

    }
}