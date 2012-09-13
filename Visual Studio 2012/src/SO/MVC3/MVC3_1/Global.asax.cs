using MVC3_1.RouteConstraints;
using MVC3_1.RouteHandlers;
using MVC3_1.Routes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC3_1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public MvcApplication()
        {
            #region Request life cycle

            this.BeginRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Begin Request");
            this.AuthenticateRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Authenticate Request");
            this.PostAuthenticateRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Authenticate Request");
            this.AuthorizeRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Authorize Request");
            this.PostAuthorizeRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Authorize Request");
            this.ResolveRequestCache += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Resolve Request Cache");
            this.PostResolveRequestCache += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Resolve Request Cache");
            this.MapRequestHandler += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Map Request Handler");
            this.PostMapRequestHandler += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Map Request Handler");
            this.AcquireRequestState += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Acquire Request State");
            this.PostAcquireRequestState += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Acquire Request State");
            this.PreRequestHandlerExecute += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Pre Request Handler Execute");
            // page events
            this.PostRequestHandlerExecute += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Request Handler Execute");
            this.ReleaseRequestState += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Release Request State");
            this.PostReleaseRequestState += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Release Request State");
            this.UpdateRequestCache += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Update Request Cache");
            this.PostUpdateRequestCache += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Update Request Cache");
            this.LogRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Log Request");
            this.PostLogRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - Post Log Request");
            this.EndRequest += (x, y) => HttpContext.Current.Trace.Warn("Global.asax - End Request");

            #endregion
        }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute() { ExceptionType = typeof(Exception), View = "Error" });
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.RouteExistingFiles = true;

            //ControllerBuilder.Current.DefaultNamespaces.Add

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.Add(new LegacyRoute("~/old/1"));

            routes.MapRoute(
                null,
                "StaticContent.html",
                new { controller = "Account", action = "Logon1" },
                new { browserConstraint = new BrowserConstraint("IE") });

            var route = routes.MapRoute(
                null,
                "catchall/{*fallback}",
                new { controller = "Home", action = "MyAction" },
                new
                {
                    controller = "^H.*",
                    action = "Index|About|myaction",
                    httpMethod = new HttpMethodConstraint("GET")
                },
                new[] { "MVC3_1.ExtraControllers" });
            route.DataTokens["UseNamespaceFallback"] = false;
            route.RouteHandler = new MvcRouteHandler();

            routes.Add(new Route("SayHello", new RouteValueDictionary(new { controller = "Legacy", action = "GetLegacyUrl" }), new CustomRouteHandler()));

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }, // Parameter defaults
                null,
                new[] { "MVC3_1.ExtraControllers" }
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}