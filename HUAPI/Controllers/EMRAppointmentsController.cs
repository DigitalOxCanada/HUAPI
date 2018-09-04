using HUAPICore.Interfaces;
using HUAPICore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// This controller targets the Appointments within the EMR
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    public class EMRAppointmentsController : ControllerBase
    {
        private readonly IOptions<CustomConfig> _cfg;
        private readonly IProfileDAL _pfd;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pfd"></param>
        /// <param name="cfg"></param>
        public EMRAppointmentsController(IProfileDAL pfd, IOptions<CustomConfig> cfg)
        {
            _cfg = cfg;
            _pfd = pfd;
        }


        /// <summary>
        /// Retrieve the appointment by the internal key id
        /// </summary>
        /// <param name="id">key id value</param>
        /// <returns>Appointment object</returns>
        [HttpGet("api/v1/[controller]/{id}")]
        public IActionResult GetAppointment([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var appointment = _pfd.GetAppointment(id);

            if (appointment == null)
            {
                return NotFound();
            }

            return Ok(appointment);
        }


        /// <summary>
        /// Get list of new appointments since a specified date.
        /// </summary>
        /// <param name="when">A date string or "now"</param>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/new/{when}")]
        public IActionResult NewAppointments([FromRoute] string when)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            DateTime dt = DateTime.Today;
            if (when != "now")
            {
                dt = Convert.ToDateTime(when);
            }

            int cnt = _pfd.GetNewAppointmentsCount(dt);

            return Ok(cnt);
        }

    }
}
