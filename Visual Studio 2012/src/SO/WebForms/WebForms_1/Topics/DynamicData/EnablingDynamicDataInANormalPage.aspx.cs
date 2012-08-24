using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_1.DataAccess;

namespace WebForms_1.Topics.DynamicData
{
    public partial class EnablingDynamicDataInANormalPage : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.gv.EnableDynamicData(typeof(jobs));
            this.ddm.RegisterControl(this.gv);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}