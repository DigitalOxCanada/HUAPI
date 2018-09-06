using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// EMR custom forms controller
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    public class EMRFormsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IProfileDAL _pfd;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pfd"></param>
        /// <param name="config"></param>
        public EMRFormsController(IProfileDAL pfd, IConfiguration config)
        {
            _config = config;
            _pfd = pfd;
        }

        /// <summary>
        /// Get a list of all the forms in the EMR system.
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/custom")]
        public IActionResult GetListofCustomForms()
        {
            var res = _pfd.GetListOfAllForms();

            return Ok(res);
        }

        /// <summary>
        /// Create the queries required to scrape a specified custom form.
        /// </summary>
        /// <param name="FormName"></param>
        /// <returns></returns>
        [Route("api/v1/[controller]/generatescrapequery/{FormName}")]
        [HttpPost]
        public IActionResult GenerateScrapeFormQueries([FromRoute] string FormName)
        {
            _pfd.GenerateScrapeFormQueries(FormName);

            return Ok(new { Message = "Completed" });
        }


    }
}