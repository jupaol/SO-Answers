using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.DynamicControls
{
    public partial class AddingDynamicControlsOnDemand : System.Web.UI.Page
    {
        protected int NumberOfControls
        {
            get
            {
                if (string.IsNullOrWhiteSpace(this.Request.Form["n"]))
                {
                    return 0;
                }

                return Convert.ToInt32(this.Request.Form["n"]);
            }
            set
            {
                this.n.Value = value.ToString();
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            for (int i = 1; i <= this.NumberOfControls; i++)
            {
                this.AddDynamicControls(i);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            this.AddDynamicControls(++this.NumberOfControls);
        }

        private void AddDynamicControls(int numberID)
        {
            var textID = "Text_" + numberID.ToString();
            var buttonID = "Button_" + numberID.ToString();
            var labelID = "Label_" + numberID.ToString();
            var textbox = this.CreateDynamicControl<TextBox>(textID);
            var button = this.CreateDynamicControl<Button>(buttonID);
            var label = this.CreateDynamicControl<Label>(labelID);

            button.Text = "Check dynamic controls";

            button.Click += (x, y) =>
                {
                    var bID = (x as Button).ID;
                    var idNumber = bID.Split('_')[1];
                    var lID = "Label_" + idNumber;
                    var tID = "Text_" + idNumber;
                    var foundLabel = (Label)this.panel.FindControl(lID);
                    var foundText = (TextBox)this.panel.FindControl(tID);

                    this.lbl.Text += "<br />" + "Click from: " + bID;
                    foundLabel.Text = foundText.Text;
                };

            this.panel.Controls.Add(label);
            this.panel.Controls.Add(textbox);
            this.panel.Controls.Add(button);
            this.panel.Controls.Add(new HtmlGenericControl("br"));
        }

        private T CreateDynamicControl<T>(string id) where T : Control, new()
        {
            var control = new T { ID = id };

            return control;
        }
    }
}