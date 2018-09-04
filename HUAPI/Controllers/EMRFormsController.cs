using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Produces("application/json")]
    [ApiController]
    public class EMRFormsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IProfileDAL _pfd;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfd"></param>
        /// <param name="config"></param>
        public EMRFormsController(IProfileDAL pfd, IConfiguration config)
        {
            _config = config;
            _pfd = pfd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("api/v1/[controller]/custom")]
        public IActionResult GetListofCustomForms()
        {
            var res = _pfd.GetListOfAllForms();

            return Ok(res);
        }

        /// <summary>
        /// 
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

        //this is for the built in recurring job to scrape custom forms every day.
        //    public void ScrapeCustomForms()
        //    {
        //        _pfd.ScrapeCustomForms("all");

        //    }

    }
}