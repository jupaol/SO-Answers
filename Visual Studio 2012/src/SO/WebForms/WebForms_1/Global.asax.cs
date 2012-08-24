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
