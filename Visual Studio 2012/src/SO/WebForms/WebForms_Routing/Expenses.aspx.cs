using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_Routing
{
    public partial class Expenses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string catchAllRoutes = string.Empty;

            if (this.RouteData.Values["extraInfo"] != null)
            {
                catchAllRoutes = this.RouteData.Values["extraInfo"].ToString();
            }

            if (!this.IsPostBack)
            {
                if (!string.IsNullOrWhiteSpace(catchAllRoutes))
                {
                    this.subCategories.DataSource = catchAllRoutes.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                    this.subCategories.DataBind();
                }
            }
        }
    }
}