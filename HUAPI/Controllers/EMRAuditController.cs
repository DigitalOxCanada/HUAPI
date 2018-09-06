using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// EMR Auditing controller
    /// </summary>
//    [Authorize(Roles = "IT Department,Administrators,Leadership Team")]
    [Produces("application/json")]
    [ApiController]
    public class EMRAuditController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly IProfileDAL _pfd;

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="pfd"></param>
        /// <param name="config"></param>
        public EMRAuditController(IProfileDAL pfd, IConfiguration config)
        {
            _config = config;
            _pfd = pfd;
        }
    }
}