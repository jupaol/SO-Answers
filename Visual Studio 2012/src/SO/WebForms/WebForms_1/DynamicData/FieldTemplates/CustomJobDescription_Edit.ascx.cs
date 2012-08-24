using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Web.DynamicData;

namespace WebForms_1.DynamicData.FieldTemplates
{
    public partial class CustomJobDescription_EditField : System.Web.DynamicData.FieldTemplateUserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.MaxLength = Column.MaxLength;
            if (Column.MaxLength < 20)
                TextBox1.Columns = Column.MaxLength;
            TextBox1.ToolTip = Column.Description;

            SetUpValidator(RequiredFieldValidator1);
            SetUpValidator(RegularExpressionValidator1);
            SetUpValidator(DynamicValidator1);
        }

        protected override void ExtractValues(IOrderedDictionary dictionary)
        {
            dictionary[Column.Name] = ConvertEditedValue(TextBox1.Text);
        }

        public override Control DataControl
        {
            get
            {
                return TextBox1;
            }
        }

        protected void cv_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = new Random((int)DateTime.Now.Ticks).Next(0, 2) == 0 ? false : true;
        }
    }
}
