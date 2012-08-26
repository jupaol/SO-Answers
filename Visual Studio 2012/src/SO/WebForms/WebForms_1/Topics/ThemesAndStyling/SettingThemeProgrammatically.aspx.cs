using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.ThemesAndStyling
{
    public partial class SettingThemeProgrammatically : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            this.Theme = "BlueTheme";
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}