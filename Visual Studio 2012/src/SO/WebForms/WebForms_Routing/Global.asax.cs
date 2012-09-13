using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using WebForms_Routing.CustomRouteConstraints;

namespace WebForms_Routing
{
    public class Global : System.Web.HttpApplication
    {
        public Global()
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

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.Ignore("{resource}.axd/{*pathInfo}");

            routes.MapPageRoute(
                "SalesSummaryRoute",
                "SalesReportSummary/{year}",
                "~/SalesSummary.aspx",
                true,
                new RouteValueDictionary { }
            );

            var route = routes.MapPageRoute(
                "SalesRoute",
                "SalesReport/{locale}/{year}",
                "~/Sales.aspx",
                true,
                new RouteValueDictionary { }
            );
            route.RouteHandler = new PageRouteHandler("~/Sales.aspx");

            routes.MapPageRoute(
                "ExpensesRoute",
                "ExpenseReport/{locale}/{year}/{*extraInfo}",
                "~/Expenses.aspx",
                true,
                new RouteValueDictionary { },
                new RouteValueDictionary { { "extraInfo", new CharactersConstraint() } }
            );
        }
    }
}