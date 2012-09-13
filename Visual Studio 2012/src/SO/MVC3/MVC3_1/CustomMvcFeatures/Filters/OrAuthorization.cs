using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3_1.CustomMvcFeatures.Filters
{
    public class OrAuthorization : AuthorizeAttribute
    {
        private string[] localUsers;

        public OrAuthorization(params string[] localUsers)
        {
            this.localUsers = localUsers;
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            return base.AuthorizeCore(httpContext) || httpContext.Request.IsLocal;
        }
    }
}