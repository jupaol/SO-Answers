using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Membership
{
    public partial class FindControlInLoginVieq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var h = this.login.FindControl("link") as HyperLink;

            this.msg.Text = h.Text;
        }
    }
}