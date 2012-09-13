using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using WebForms_1;
using WebForms_1.DataAccess;

namespace WebForms_1
{
    public class Global : HttpApplication
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

        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterOpenAuth();

            //MetaModel model = new MetaModel();
            //model.RegisterContext(typeof(PubsDataContext),
            //new ContextConfiguration() { ScaffoldAllTables = false });
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
