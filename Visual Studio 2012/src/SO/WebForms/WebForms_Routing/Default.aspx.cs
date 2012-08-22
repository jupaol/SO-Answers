using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Routing
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.SetNavigateUrl(this.salesReportSummaryLink, new RouteValueDictionary { {"year", 2010} });
            this.SetNavigateUrl(this.salesReportLink, new RouteValueDictionary { { "year", 2011 }, { "locale", "WA" } }, "SalesRoute");
            this.SetNavigateUrl(this.expenseReportLink, new RouteValueDictionary { { "year", 2012 }, { "locale", "CA" }, { "page", 10 }, { "game", "Warcraft" }, { "extraInfo", "Leviatans/Kenfo/Syilar" } }, "ExpensesRoute");
        }

        private void SetNavigateUrl(HyperLink linkControl, RouteValueDictionary routeValues, string routeName = "")
        {
            VirtualPathData pathDate = RouteTable.Routes.GetVirtualPath(null, routeName, routeValues);

            linkControl.NavigateUrl = pathDate.VirtualPath;
        }
    }
}