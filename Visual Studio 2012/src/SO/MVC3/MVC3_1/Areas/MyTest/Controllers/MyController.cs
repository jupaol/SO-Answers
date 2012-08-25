using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC3_1.Areas.MyTest.Controllers
{
    public class MyController : Controller
    {
        //
        // GET: /MyTest/My/

        public ActionResult MyHome()
        {
            return View();
        }

    }
}
