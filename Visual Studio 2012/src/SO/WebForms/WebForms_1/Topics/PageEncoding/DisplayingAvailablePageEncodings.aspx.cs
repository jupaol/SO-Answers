using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.PageEncoding
{
    public partial class DisplayingAvailablePageEncodings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.gv.DataSource = Encoding.GetEncodings();
            this.gv.DataBind();
        }
    }
}