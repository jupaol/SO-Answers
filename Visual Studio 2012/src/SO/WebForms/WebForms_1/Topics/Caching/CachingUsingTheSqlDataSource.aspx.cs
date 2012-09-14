using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Caching
{
    public partial class CachingUsingTheSqlDataSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.msg.Text = "From cache";
        }

        protected void sds_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            this.Trace.Warn("From database");
            this.msg.Text = "From database";
        }
    }
}