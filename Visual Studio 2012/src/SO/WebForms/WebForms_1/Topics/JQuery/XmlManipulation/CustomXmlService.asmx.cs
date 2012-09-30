using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Xml.Linq;

namespace WebForms_1.Topics.JQuery.XmlManipulation
{
    /// <summary>
    /// Summary description for CustomXmlService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class CustomXmlService : System.Web.Services.WebService
    {

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Xml, UseHttpGet = true)]
        public string GetCustomXml()
        {
            var d = XDocument.Load(Server.MapPath("~/Topics/JQuery/XmlManipulation/CustomXml.xml"));
            var c = d.ToString();

            Thread.Sleep(2000);

            return c;
        }
    }
}
