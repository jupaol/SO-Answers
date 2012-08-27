using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DynamicControls
{
    public partial class AddingDynamicUserControlsOnDemand : System.Web.UI.Page
    {
        protected int NumberOfControls
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.hidden.Value))
                {
                    return 0;
                }

                return Convert.ToInt32(this.hidden.Value);
            }
            set
            {
                this.hidden.Value = value.ToString();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= this.NumberOfControls; i++)
            {
                this.AddDynamicUserControl(i);
            }
        }

        protected void add_Click(object sender, EventArgs e)
        {
            this.AddDynamicUserControl(++this.NumberOfControls);
        }

        private void AddDynamicUserControl(int number)
        {
            var uc = this.LoadControl("~/Topics/DynamicControls/AddressControl.ascx");

            this.panel.Controls.Add(uc);
            this.panel.Controls.Add(new HtmlGenericControl("br"));
        }
    }
}