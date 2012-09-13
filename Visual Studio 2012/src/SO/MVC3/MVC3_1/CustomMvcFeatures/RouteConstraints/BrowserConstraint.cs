using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MVC3_1.RouteConstraints
{
    public class BrowserConstraint : IRouteConstraint
    {
        private string userAgent;

        public BrowserConstraint(string userAgent)
        {
            this.userAgent = userAgent;
        }

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return !string.IsNullOrWhiteSpace(httpContext.Request.UserAgent) && httpContext.Request.UserAgent.Contains(this.userAgent);
        }
    }
}