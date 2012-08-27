using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.ControlState
{
    [AspNetHostingPermission(SecurityAction.Demand, Level = AspNetHostingPermissionLevel.Minimal)]
    [AspNetHostingPermission(SecurityAction.InheritanceDemand, Level = AspNetHostingPermissionLevel.Minimal)]
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:AddressServerControl runat=server></{0}:AddressServerControl>")]
    public class AddressServerControl : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? String.Empty : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }

        public int Count { get; set; }

        //[Bindable(true)]
        //[Category("Apperance")]
        //[DefaultValue(0)]
        //[Localizable(false)]
        //public int Count
        //{
        //    get
        //    {
        //        var c = this.ViewState["c"];

        //        if (c == null)
        //        {
        //            return 0;
        //        }

        //        return Convert.ToInt32(c);
        //    }
        //    set
        //    {
        //        this.ViewState["c"] = value;
        //    }
        //}

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(Text);
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            this.Page.RegisterRequiresControlState(this);
        }

        protected override object SaveControlState()
        {
            var o = base.SaveControlState();

            if (o != null)
            {
                return new Pair(o, this.Count);
            }
            else
            {
                return this.Count;
            }
        }

        protected override void LoadControlState(object savedState)
        {
            if (savedState != null)
            {
                if (savedState is Pair)
                {
                    var pair = savedState as Pair;

                    base.LoadControlState(pair.First);
                    this.Count = Convert.ToInt32(pair.Second);
                }

                if (savedState is Int32)
                {
                    this.Count = Convert.ToInt32(savedState);
                }
            }
        }
    }
}
