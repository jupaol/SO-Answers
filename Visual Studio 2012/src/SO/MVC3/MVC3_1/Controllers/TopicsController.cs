using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace MVC3_1.Controllers
{
    [SessionState(SessionStateBehavior.Required)]
    public class TopicsController : Controller
    {
        [HttpPost]
        public JsonResult Operation1()
        {
            this.Session["c"] = DateTime.Now;
            Thread.Sleep(10000);
            return Json(new { Message = "Operation1: " + DateTime.Now.ToString() + " from session: " + this.Session["c"].ToString() });
        }

        [HttpPost]
        public JsonResult Operation2()
        {
            this.Session["c"] = DateTime.Now;
            Thread.Sleep(15000);
            return Json(new { Message = "Operation1: " + DateTime.Now.ToString() + " from session: " + this.Session["c"].ToString() });
        }

        [HttpPost]
        public JsonResult Operation3()
        {
            this.Session["c"] = DateTime.Now;
            Thread.Sleep(5000);
            return Json(new { Message = "Operation1: " + DateTime.Now.ToString() + " from session: " + this.Session["c"].ToString() });
        }
    }
}
