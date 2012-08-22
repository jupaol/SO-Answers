using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1
{
    public partial class UpdatePanel_Trigger_FromInside : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void timer_Load(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
        }

        protected void timer_Tick(object sender, EventArgs e)
        {

        }
    }
}