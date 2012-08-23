using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.OutputCaching
{
    public partial class OutputCaching_VaryByParamUsingCode : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            this.Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
            this.Response.Cache.SetCacheability(HttpCacheability.Server);
            this.Response.Cache.SetValidUntilExpires(true);
            //this.Response.Cache.VaryByParams["none"] = true;
            this.Response.Cache.VaryByParams["ddl"] = true;

            //this.InitOutputCache(new OutputCacheParameters
            //    {
            //        Duration=60,
            //        VaryByParam = "none"
            //    });
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.ddl.DataSource = Enumerable.Range(10, 5).Select(x => new { Text = "Something" + x.ToString(), Value = x });
                this.ddl.DataBind();
            }

            this.lbl.Text = DateTime.Now.ToString();
            this.lblClient.Text = this.ddl.ClientID;
            this.lblServer.Text = this.ddl.ID;
            this.lblUnique.Text = this.ddl.UniqueID;
        }
    }
}