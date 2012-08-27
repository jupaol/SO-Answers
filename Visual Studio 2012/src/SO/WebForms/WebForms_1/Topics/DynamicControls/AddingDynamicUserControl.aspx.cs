using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DynamicControls
{
    public partial class AddingDynamicUserControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var uc = this.LoadControl("~/Topics/DynamicControls/AddressControl.ascx");

            this.panel.Controls.Add(uc);
        }
    }
}