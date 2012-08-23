using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.OutputCaching
{
    public partial class OutputCaching_FilesDependency : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var filePath = "~/Topics/OutputCaching/File1.txt";

            this.Response.AddFileDependency(Server.MapPath(filePath));

            this.lblRendered.Text = DateTime.Now.ToString();
            this.lbl.Text = string.Join("<br/>", File.ReadAllLines(Server.MapPath(filePath)));
        }
    }
}