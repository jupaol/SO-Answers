using FizzWare.NBuilder;
using MVC3_1.CustomMvcFeatures.ActionResults;
using MVC3_1.CustomMvcFeatures.Filters;
using MVC3_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVC3_1.ExtraControllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Person()
        {
            return View(new PersonModelView { Birtday = new DateTime(1979, 11, 29) });
        }

        [HttpDelete]
        public ActionResult Person(PersonModelView personViewModel)
        {
            return View(personViewModel);
        }

        public ActionResult MyAction()
        {
            return View();
        }

        public RssActionResult FeedNews()
        {
            var feeds = Builder<NewsFeed>.CreateListOfSize(10).Build();

            return new RssActionResult<NewsFeed>("Sports Store News", feeds, x => new XElement(
                "item",
                new XAttribute("title", x.Title),
                new XAttribute("description", x.Description),
                new XAttribute("link", x.Url)
            ));
        }

        [OrAuthorization]
        public ActionResult CustomAuthorization()
        {
            return View();
        }

        public ActionResult RaiseException()
        {
            throw new NotImplementedException();
        }

        public ActionResult ParentNoCachedAction()
        {
            return View(DateTime.Now);
        }

        [OutputCache(Duration = 30)]
        public ActionResult CachedChildAction()
        {
            return View(DateTime.Now);
        }

        public ActionResult ConcurrentRequests()
        {
            return View();
        }
    }
}
