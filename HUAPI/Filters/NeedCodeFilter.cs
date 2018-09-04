using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace HUAPICore.Filters
{

    internal class CodeCookie
    {
        public string UserName { get; set; }
        public DateTime Expires { get; set; }
        public string Api { get; set; }

        public string Code { get; set; }
    }

    /// <summary>
    /// This allows using [NeedCode] attribute on a controller method that will invoke this code to execute during the pipeline.
    /// The purpose of NeedCode is to require a confirmation step by the human so that some controller methods don't accidentally get triggered with a single call.
    /// ie. scraping all the forms accidentally would be bad since it involved dropping tables and hitting the production server hard.
    /// </summary>
    public class NeedCodeFilterAttribute : TypeFilterAttribute
    {
        /// <summary>
        /// 
        /// </summary>
        public NeedCodeFilterAttribute() : base(typeof(NeedCodeFilterImpl))
        {

        }


        /// <summary>
        /// 
        /// </summary>
        private class NeedCodeFilterImpl : IActionFilter
        {
            private static List<CodeCookie> codeList = new List<CodeCookie>();

            /// <summary>
            /// Ctor
            /// </summary>
            public NeedCodeFilterImpl() //here you can use DI
            {
            }

            /// <summary>
            /// Executes when the controller action is called and the [NeedCode] attribute has been specified.
            /// </summary>
            /// <param name="context"></param>
            public void OnActionExecuting(ActionExecutingContext context)
            {
                var api = context.HttpContext.Request.Path;
                var returnedapicode = "";

                //clean the list of expired ones
                var dt = DateTime.Now;
                codeList.RemoveAll(a => a.Expires < dt);


                if (context.HttpContext.Request.QueryString.HasValue)
                {
                    //we got something on the url so lets use that to determine going forward or not.
                    var queryDictionary = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(context.HttpContext.Request.QueryString.Value);
                    returnedapicode = queryDictionary["apicode"];
                }

                string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

                Random r = new Random();
                CodeCookie currentCookie = null;

                //if no this means this is the first time this method is called from an API that needs a code
                if (string.IsNullOrEmpty(returnedapicode))
                {
                    //we didn't find a code so lets generate one and send them on their way.
                    CodeCookie newCookie = new CodeCookie()
                    {
                        UserName = userName,
                        Code = r.Next(1048576, 10485760).ToString(),
                        Expires = DateTime.Now.AddMinutes(5),
                        Api = api
                    };

                    codeList.Add(newCookie);

                    //redirect
                    context.Result = new ContentResult() { Content = System.IO.File.ReadAllText("Filters/needcode.html").Replace("{{api}}", newCookie.Api).Replace("{{apicode}}", newCookie.Code).Replace("{{tl}}", newCookie.Expires.ToString()), ContentType = "text/html" };
                    return;
                }
                else
                {
                    //we have a code, so lets see if it is in our list and within the time frame.
                    foreach (var cookie in codeList)
                    {
                        //if the querystring url matches on record api
                        if (cookie.Api == api && cookie.UserName == userName && cookie.Code == returnedapicode)
                        {
                            if (dt.Ticks < cookie.Expires.Ticks)
                            {
                                //if we still have time left we accept this code
                                currentCookie = cookie;
                                break;
                            }
                        }
                    }

                    if (currentCookie != null)
                    {
                        codeList.Remove(currentCookie);
                        //context.Result = new ContentResult
                        //{
                        //    Content = "I'll skip the action execution"
                        //};
                    }
                    else
                    {
                        //invalid code or time ran out, so generate a new one 
                        CodeCookie newCookie = new CodeCookie()
                        {
                            UserName = userName,
                            Code = r.Next(1048576, 10485760).ToString(),
                            Expires = DateTime.Now.AddMinutes(5),
                            Api = api
                        };

                        codeList.Add(newCookie);

                        //redirect
                        context.Result = new ContentResult() { Content = System.IO.File.ReadAllText("Filters/needcode.html").Replace("{{api}}", newCookie.Api).Replace("{{apicode}}", newCookie.Code).Replace("{{tl}}", newCookie.Expires.Ticks.ToString()), ContentType = "text/html" };
                        return;
                    }

                }
                //return;
            }

            public void OnActionExecuted(ActionExecutedContext context)
            {
            }

        }
    }
}
