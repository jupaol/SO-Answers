using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Page_ViewState
{
    public partial class Global : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ddl.DataSource = Enumerable.Range(1, 10);
                this.ddl.DataBind();
            }
        }
    }
}