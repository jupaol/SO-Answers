using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_1.DataAccess;

namespace WebForms_1.Topics.Page_ViewState
{
    public partial class EnablingViewStatePerControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.GridView1.DataSource = new PubsDataContext().employee;
                this.GridView1.DataBind();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.GridView1.PageIndex = e.NewPageIndex;
            this.GridView1.DataSource = new PubsDataContext().employee;
            this.GridView1.DataBind();
        }
    }
}