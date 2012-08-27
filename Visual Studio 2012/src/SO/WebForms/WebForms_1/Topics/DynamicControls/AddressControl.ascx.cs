using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DynamicControls
{
    public partial class AddressControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void process_Click(object sender, EventArgs e)
        {
            this.lbl.Text += "<br />" + this.txt.Text;
        }
    }
}