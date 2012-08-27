using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DynamicControls
{
    public partial class AddingMultipleDynamicControls : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var id = "Button" + (i + 1).ToString();
                var c = this.CreateDynamicControl<Button>(id);

                c.Text = id;
                c.Click += (x, y) => this.lbl.Text += "<br/>" + (x as Button).ID;

                this.panel.Controls.Add(c);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private T CreateDynamicControl<T>(string id) where T : Control, new()
        {
            var control = new T { ID = id };

            return control;
        }
    }
}