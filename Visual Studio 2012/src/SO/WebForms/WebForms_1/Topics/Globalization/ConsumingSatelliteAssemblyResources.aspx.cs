using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Globalization
{
    public partial class ConsumingSatelliteAssemblyResources : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture =
                    System.Globalization.CultureInfo.CreateSpecificCulture(this.languages.SelectedValue);
            }
            else
            {
                this.languages.Items.FindByValue(
                    System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName
                    ).Selected = true;
            }
        }

        protected void languages_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                System.Globalization.CultureInfo.CreateSpecificCulture(this.languages.SelectedValue);
        }
    }
}