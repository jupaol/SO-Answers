using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DynamicControls
{
    public partial class SimpleDynamicControls : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            var button = new Button { ID = "button1", Text = "Added dynamically" };

            button.Click += (x, y) => this.lbl.Text = DateTime.Now.ToString();

            this.panel.Controls.Add(button);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}