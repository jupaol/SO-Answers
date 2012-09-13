using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVC3_1.CustomMvcFeatures.ActionResults
{
    public abstract class RssActionResult : ActionResult
    {
    }

    public class RssActionResult<T> : RssActionResult
    {
        public string Title { get; set; }
        public IEnumerable<T> Data { get; set; }
        public Func<T, XElement> Formatter { get; set; }

        public RssActionResult(string title, IEnumerable<T> data, Func<T, XElement> formatter)
        {
            this.Title = title;
            this.Data = data;
            this.Formatter = formatter;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;
            var rss = this.GenerateXml(response.ContentEncoding.WebName);

            response.ContentType = "application/rss+xml";
            response.Write(rss);
        }

        private string GenerateXml(string encoding)
        {
            var title = new XElement("title", this.Title);
            var channel = new XElement("channel", title, this.Data.Select(t => this.Formatter(t)));
            var version = new XAttribute("version", "2.0");
            var rssRoot = new XElement("rss", version);
            var declaration = new XDeclaration("1.0", encoding, "yes");

            //var rss = new XDocument(
            //    new XDeclaration("1.0", encoding, "yes"),
            //    new XElement("rss", new XAttribute("version", "2.0"),
            //        new XElement("channel", new XElement("title", this.Title), this.Data.Select(e => this.Formatter(e))))
            //    );

            var rss = new XDocument(declaration, rssRoot);

            return rss.ToString();
        }
    }

}