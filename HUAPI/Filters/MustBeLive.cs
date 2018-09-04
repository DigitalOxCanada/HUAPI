using HUAPICore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUAPICore.Filters
{
    /// <summary>
    /// This allows using [MustBeLive] attribute on a controller method that will invoke this code to execute during the pipeline.
    /// The purpose of MustBeLive is to require the system to be "live" for the method to execute.
    /// ie. a scheduled method to perform maintenance tasks should only execute when the system is live.
    /// </summary>
    public class MustBeLiveFilterAttribute : TypeFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public MustBeLiveFilterAttribute() : base(typeof(MustBeLiveFilterImpl))
        { }

        private class MustBeLiveFilterImpl : IActionFilter
        {

            private readonly ISettings _settings;

            public MustBeLiveFilterImpl(ISettings settings)
            {
                _settings = settings;
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                _settings.ReadSettings();
                bool isLive = false;
                Boolean.TryParse(_settings.Settings["IsLive"], out isLive);
                if (!isLive)
                {
                    context.Result = new ContentResult()
                    {
                        Content = "Resource unavailable - system must be live"
                    };
                }
            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
                
            }

            public bool IsReusable
            {
                get
                {
                    return false;
                }
            }
        }

    }
}
