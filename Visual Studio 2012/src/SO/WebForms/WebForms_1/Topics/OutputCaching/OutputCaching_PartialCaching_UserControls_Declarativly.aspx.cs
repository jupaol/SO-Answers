﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.OutputCaching
{
    public partial class OutputCaching_PartialCaching_UserControls_Declarativly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.lbl.Text = DateTime.Now.ToString();
        }

        protected void timer_Load(object sender, EventArgs e)
        {

        }
    }
}