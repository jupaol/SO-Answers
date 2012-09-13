using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3_1.HttpHandlers
{
    public class CustomHttpHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("Hello world from custom HTTP handler");
        }
    }
}