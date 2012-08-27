using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Page_ViewState
{
    public partial class CompressPageViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void SavePageStateToPersistenceMedium(object state)
        {
            LosFormatter formatter = new LosFormatter();
            StringWriter writer = new StringWriter();

            formatter.Serialize(writer, state);

            string viewStateString = writer.ToString();
            byte[] bytes = Convert.FromBase64String(viewStateString);

            this.normalViewState.Text = viewStateString;

            bytes = bytes.Compress();
            this.encryptedViewState.Text = Convert.ToBase64String(bytes);

            ClientScript.RegisterHiddenField("__VSTATE", Convert.ToBase64String(bytes));
        }

        protected override object LoadPageStateFromPersistenceMedium()
        {
            string viewState = Request.Form["__VSTATE"];
            byte[] bytes = Convert.FromBase64String(viewState);
            LosFormatter formatter = new LosFormatter();

            bytes = bytes.Decompress();

            return formatter.Deserialize(Convert.ToBase64String(bytes));
        }
    }
}