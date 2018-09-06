using HUAPIClassLibrary;
using HUAPICore.Interfaces;
using HUAPICore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// Forwarding Links controller
    /// </summary>
    [Produces("application/json")]
    public class FWLinkController : Controller
    {
        private readonly IFWLinkService _fwlinkRepository;
        private readonly ILogger<FWLinkController> _logger;
        //        private readonly IHostingEnvironment _hostingEnv;
        //        private readonly IOptions<CustomConfig> _customConfig;


        /// <summary>
        /// A URL forwarding service similar to Microsoft's FWLink or a short url.
        /// </summary>
        /// <param name="fwlinkRepository"></param>
        /// <param name="logger"></param>
        public FWLinkController(IFWLinkService fwlinkRepository, ILogger<FWLinkController> logger) // IOptions<CustomConfig> cfg, IHostingEnvironment env
        {
            _fwlinkRepository = fwlinkRepository;
            _logger = logger;
            //            _customConfig = cfg;
            //            _hostingEnv = env;
        }

        /// <summary>
        /// Redirect to the url stored and associated with the fwlinkid
        /// </summary>
        /// <param name="fwlinkid">number id</param>
        [Route("fwlink/{fwlinkid:long}")]
        [HttpGet]
        public IActionResult GoFWLink(long fwlinkid)
        {
            FWLink link = _fwlinkRepository.FindById(fwlinkid);
            if (link == null)
            {
                return NotFound();
            }
            return Redirect(link.Url);
        }

        /// <summary>
        /// Search for fwlink entry that matches the id
        /// </summary>
        /// <param name="fwlinkid">number id</param>
        /// <returns></returns>
        /// <remarks>Awesome!</remarks>
        /// <response code="200">Link was found in the system</response>
        /// <response code="204">Link was no found</response>
        [Route("fwlink/find/{fwlinkid:long}")]
        [HttpGet]
        [ProducesResponseType(typeof(FWLink), 200)]
        //[ProducesResponseType(typeof(void), 204)]
        //[ApiExplorerSettings(GroupName = "v2")]
        public IActionResult GetFWLink(long fwlinkid)
        {
            FWLink link = _fwlinkRepository.FindById(fwlinkid);
            if (link == null)
            {
                return NoContent();
            }
            return Ok(link);
            //return Ok(link);
        }


        /// <summary>
        /// Add a new fwlink object to the system.
        /// </summary>
        /// <param name="newlink">URL of new fwlink</param>
        /// <returns>fwlink object</returns>
        [Route("fwlink")]
        [HttpPost]
        public IActionResult AddFWLink([FromBody]FWLink newlink)
        {
            try
            {
                if (newlink == null || !ModelState.IsValid)
                {
                    return BadRequest(ErrorCode.ItemValuesRequired.ToString());
                }
                FWLink itemExists = _fwlinkRepository.FindByUrl(newlink.Url);
                if (itemExists != null)
                {
                    return StatusCode(StatusCodes.Status409Conflict, ErrorCode.ItemExists.ToString());
                }
                _fwlinkRepository.Insert(newlink);
            }
            catch (Exception ex)
            {
                return BadRequest(ErrorCode.CouldNotCreateItem.ToString());
            }
            return Ok(newlink);

        }

    }
}
