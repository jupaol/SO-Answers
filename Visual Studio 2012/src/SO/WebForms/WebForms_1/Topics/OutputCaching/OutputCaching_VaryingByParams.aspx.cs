using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.OutputCaching
{
    public partial class OutputCaching_VaryingByParams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ddl.DataSource = Enumerable.Range(10, 20);
                this.ddl.DataBind();
            }

            this.literal.Text = DateTime.Now.ToString();
        }

        public static string GetCurrentTime(HttpContext context)
        {
            return DateTime.Now.ToString();
        }
    }
}