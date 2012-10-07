using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DataBinding.ForListView
{
    public partial class BindingControlInsideTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void listView_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "New":
                    this.listView.InsertItemPosition = InsertItemPosition.LastItem;
                    break;
                default:
                    break;
            }
        }

        protected void listView_ItemCreated(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.InsertItem)
            {
                var drop = e.Item.FindControl("myDropDownListInsideATemplate") as DropDownList;

                // here bind your control
                drop.DataSource = Enumerable.Range(1, 20);
                drop.DataBind();
            }
        }
    }
}