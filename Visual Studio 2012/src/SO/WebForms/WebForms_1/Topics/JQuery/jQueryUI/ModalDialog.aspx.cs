using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.JQuery.jQueryUI
{
    public partial class ModalDialog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void foo_Click(object sender, EventArgs e)
        {
            this.msg.Text = "event called";
        }
    }
}