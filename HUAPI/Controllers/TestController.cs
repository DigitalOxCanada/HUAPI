using HUAPICore.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// Test controller
    /// </summary>
    [Produces("application/json")]
    public class TestController : Controller
    {
        private ILogger<TestController> _logger;


        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="logger"></param>
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Does nothing.
        /// </summary>
        /// <returns>StatusCode 200</returns>
        [HttpGet("api/[controller]")]
        public IActionResult Index()
        {
            _logger.LogInformation("api/test success");
            return Ok();
        }

        /// <summary>
        /// Tests the Need Code filter
        /// </summary>
        /// <returns>StatusCode 200</returns>
        [HttpGet("api/[controller]/needcode")]
        [NeedCodeFilter]        //[ServiceFilter(typeof(NeedCodeFilterAttribute))]
        public IActionResult NeedCodeTest()
        {
            _logger.LogInformation("api/test/needcode success");
            return Ok(new { Message = "Success" });
        }

        /// <summary>
        /// Tests the mustbelive filter
        /// </summary>
        /// <returns>StatusCode 200</returns>
        [HttpGet("api/[controller]/mustbelive")]
        [MustBeLiveFilter]        //[ServiceFilter(typeof(MustBeLiveFilterAttribute))]
        public IActionResult MustBeLiveTest()
        {
            _logger.LogInformation("api/test/mustbelive success");
            return Ok(new { Message = "Success" });
        }

    }
}


