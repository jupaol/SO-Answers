using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.ConfigSettings
{
    public partial class TestingCustomConfigurationSettings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var config = (SampleConfigurationSection)ConfigurationManager.GetSection("sampleConfiguration");

            this.chk.Checked = config.RemoteOnly;
            this.body.Attributes.Add("bgcolor", config.Color.Background);
            this.body.Attributes.Add("style", "color:" + config.Color.Foreground);
        }
    }
}