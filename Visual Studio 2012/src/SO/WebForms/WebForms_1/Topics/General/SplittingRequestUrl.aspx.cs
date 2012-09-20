using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.General
{
    public partial class SplittingRequestUrl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var req = this.Request;
            var d = new Dictionary<string, string>
            {
                { "Request: Raw URL", req.RawUrl },
                { "Request: Physical path", req.PhysicalPath },
                { "Request: Physical application path", req.PhysicalApplicationPath },
                { "Request: Path info", req.PathInfo },
                { "Request: Path", req.Path },
                { "Absolute Path", req.Url.AbsolutePath },
                { "Absolute URI", req.Url.AbsoluteUri },
                { "Authority", req.Url.Authority },
                { "Dns Safe Host", req.Url.DnsSafeHost },
                { "Fragment", req.Url.Fragment },
                { "Host", req.Url.Host },
                { "Is absoluite url", req.Url.IsAbsoluteUri.ToString() },
                { "Is default port", req.Url.IsDefaultPort.ToString() },
                { "Is file", req.Url.IsFile.ToString() },
                { "Is loopback", req.Url.IsLoopback.ToString() },
                { "Is Unc", req.Url.IsUnc.ToString() },
                { "Local path", req.Url.LocalPath },
                { "Original string", req.Url.OriginalString },
                { "Path and query", req.Url.PathAndQuery },
                { "Port", req.Url.Port.ToString() },
                { "Query", req.Url.Query },
                { "Scheme", req.Url.Scheme },
                { "User escaped", req.Url.UserEscaped.ToString() },
                { "User Info", req.Url.UserInfo }
            };

            this.gv.DataSource = d;
            this.gv.DataBind();
        }
    }
}