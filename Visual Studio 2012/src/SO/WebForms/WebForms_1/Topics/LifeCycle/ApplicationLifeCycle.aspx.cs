using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.LifeCycle
{
    public partial class ApplicationLifeCycle : System.Web.UI.Page
    {
        public ApplicationLifeCycle()
        {
            HttpContext.Current.Trace.Warn("Page Ctor");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Trace.Warn("aspx.page", "Button Click");
        }

        protected void Unnamed_CheckedChanged(object sender, EventArgs e)
        {
            HttpContext.Current.Trace.Warn("aspx.page", "Checked Changed");
        }
    }
}