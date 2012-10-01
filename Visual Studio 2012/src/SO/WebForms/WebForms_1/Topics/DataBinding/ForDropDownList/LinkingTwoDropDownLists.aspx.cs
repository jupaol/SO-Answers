using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DataBinding.ForDropDownList
{
    public partial class LinkingTwoDropDownLists : System.Web.UI.Page
    {
        private const int MaxYear = 2030;
        private const int MinYear = 1959;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                var fromRange = Enumerable.Range(MinYear, MaxYear - MinYear);

                this.from.DataSource = fromRange;
                this.from.DataBind();
            }
        }

        protected void from_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedYear = Convert.ToInt32(this.from.SelectedValue);
            var toRange = Enumerable.Range(selectedYear, MaxYear - selectedYear);

            this.to.DataSource = toRange;
            this.to.DataBind();
        }
    }
}