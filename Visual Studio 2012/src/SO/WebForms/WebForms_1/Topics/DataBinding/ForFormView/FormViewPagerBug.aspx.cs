using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_1.DataAccess;

namespace WebForms_1.Topics.DataBinding
{
    public partial class FormViewPagerBug : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ldse_Selecting(object sender, LinqDataSourceSelectEventArgs e)
        {
            e.Result = new PubsDataContext().employee.Take(1);
        }

        protected void Unnamed_ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Save":
                    this.res.Text = ((DropDownList)this.formView.FindControl("ddlJobs")).SelectedValue;
                    break;
                case "Cancel":
                    this.res.Text = string.Empty;
                    break;
                default:
                    throw new InvalidOperationException("Invalid command");
            }
        }
    }
}