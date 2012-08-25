using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var languages = Request.UserLanguages;
            var ci = new CultureInfo(languages[0]);
            var en = ci.EnglishName;
        }
    }
}