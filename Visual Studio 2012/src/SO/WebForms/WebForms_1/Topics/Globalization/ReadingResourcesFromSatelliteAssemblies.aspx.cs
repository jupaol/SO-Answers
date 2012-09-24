using SampleControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Globalization
{
    public partial class ReadingResourcesFromSatelliteAssemblies : System.Web.UI.Page
    {
        protected override void InitializeCulture()
        {
            this.Culture = "it-IT";
            this.UICulture = "it-IT";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var rm = new ResourceManager("SampleControl.VerificationResources", typeof(ClientVerification).Assembly);

            this.msg.Text = rm.GetString("Correct");
        }
    }
}