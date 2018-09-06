using HUAPICore.Models;
using HUAPICore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace HUAPICore.Controllers
{
    /// <summary>
    /// Password Generator API
    /// </summary>
    [Produces("application/json")]
    public class PasswordGenController : Controller
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public PasswordGenController()
        {
        }

        /// <summary>
        /// Execute a password generation and return a list of generated passwords.
        /// </summary>
        /// <param name="body"></param>
        /// <returns></returns>
        [HttpPost("api/v1/PasswordGen/Generate")]
        public IActionResult Generate([FromBody]PasswordGenModel body)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            List<string> pwds = new List<string>();

            PasswordGen pwdGen = new PasswordGen()
            {
                Exclusions = Convert.ToString(body.Exclusions),
                Maximum = Convert.ToInt32(body.Maximum),
                ConsecutiveCharacters = Convert.ToBoolean(body.ConsecutiveCharacters),
                RepeatCharacters = Convert.ToBoolean(body.RepeatCharacters),
                ExcludeSymbols = Convert.ToBoolean(body.ExcludeSymbols)
            };

            for (int i = 0; i < 10; i++)
            {
                string pwd = pwdGen.Generate();
                pwds.Add(pwd);
            }

            return Ok(pwds);
        }

    }
}
