using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace WebForms_1.Topics.HttpHandlers
{
    public class RedirectModule : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += handler;
        }

        void handler(object sender, EventArgs e)
        {
            var context = (sender as HttpApplication).Context;
            var physicalPath = context.Request.PhysicalPath;
            var folder = Path.GetDirectoryName(physicalPath);
            var fileName = Path.GetFileName(physicalPath);

            if (!Path.GetExtension(physicalPath).Equals(".aspx", StringComparison.InvariantCultureIgnoreCase))
            {
                return;
            }

            var currentReques = context.Request.RawUrl;
            var query = context.Request.Url.Query;
            var currentDomainWithPort = context.Request.Url.AbsoluteUri.Replace(currentReques, string.Empty);

            // we know for sure the requeted file is located inside the blog folder
            if (folder.ToLowerInvariant().Contains(@"\blog"))
            {
                //path to your Blog subfolder
                if (!currentReques.StartsWith("/Topics/HttpHandlers/Blog", StringComparison.InvariantCultureIgnoreCase))
                {
                    // if this condition is met, it means that a page inside the folder is
                    // firing an old link that needs to be configured

                    context.Response.Clear();
                    context.Response.RedirectPermanent(
                        string.Format("{0}/Topics/HttpHandlers/Blog/{1}{2}",
                            currentDomainWithPort, fileName, query));
                }
            }
        }
    }
}