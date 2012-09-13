using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC3_1.Routes
{
    public class LegacyRoute : RouteBase
    {
        private string[] urls;

        public LegacyRoute(params string[] urls)
        {
            this.urls = urls;
            HttpContext.Current.Trace.Warn("routes", "LegacyRoute - ctor");
        }

        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            HttpContext.Current.Trace.Warn("routes", "LegacyRoute - GetRouteData");

            var requestedUrl = httpContext.Request.AppRelativeCurrentExecutionFilePath;
            RouteData routeData = null;

            if (this.urls.Contains(requestedUrl, StringComparer.OrdinalIgnoreCase))
            {
                routeData = new RouteData(this, new MvcRouteHandler());

                routeData.Values.Add("controller", "Legacy");
                routeData.Values.Add("action", "GetLegacyUrl");
                routeData.Values.Add("legacyUrl", requestedUrl);
            }

            return routeData;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            VirtualPathData virtualPathData = null;

            if (values.ContainsKey("legacyUrl") && this.urls.Contains(values["legacyUrl"].ToString(), StringComparer.OrdinalIgnoreCase))
            {
                virtualPathData = new VirtualPathData(this, new UrlHelper(requestContext).Content(values["legacyUrl"].ToString().Substring(2)));
            }

            return virtualPathData;
        }
    }
}