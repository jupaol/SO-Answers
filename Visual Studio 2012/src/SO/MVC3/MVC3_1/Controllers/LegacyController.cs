using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3_1.Controllers
{
    public class LegacyController : Controller
    {
        public ActionResult GetLegacyUrl(string legacyUrl)
        {
            this.HttpContext.Trace.Warn("controller", "LegacyController - GetLegacyUrl");

            return View((object)legacyUrl);
        }

    }
}
