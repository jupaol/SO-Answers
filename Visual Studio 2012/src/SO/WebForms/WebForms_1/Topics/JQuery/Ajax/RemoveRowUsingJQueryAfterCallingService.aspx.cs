using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.JQuery.Ajax
{
    public partial class RemoveRowUsingJQueryAfterCallingService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static void Remove(Int16 id)
        {
            // simulate deleting the file
            Thread.Sleep(3000);
        }
    }
}