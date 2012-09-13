using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC3_1.Controllers;

namespace MVC3_1Tests
{
    [TestClass]
    public class MvcRouting
    {
        [TestMethod]
        public void testing_global_routes()
        {
            //"~/".ShouldMapTo<HomeController>(x => x.Index());

            StaticUtils.TestRouteMatch("~/", "Home", "Index");
            StaticUtils.TestRouteMatch("~/Home/Index", "Home", "Index");
            StaticUtils.TestRouteMatch("~/home/index/43", "Home", "index", new { id = "43" });
            StaticUtils.TestRouteFail("~/home/index/sub/43");

            StaticUtils.TestRouteMatch("~/catchall", "Home", "myaction");
            StaticUtils.TestRouteMatch("~/catchall/first", "Home", "myaction");
            StaticUtils.TestRouteMatch("~/catchall/first/second", "Home", "myaction");
            StaticUtils.TestRouteMatch("~/catchall/first/second/thirf", "Home", "myaction");

            StaticUtils.TestRouteMatch("~/StaticContent.html", "Account", "Logon1");

            StaticUtils.TestRouteMatch("~/old/1", "Legacy", "GetLegacyUrl", new { legacyUrl = "~/old/1" });
        }

        [TestMethod]
        public void test_outgoing_routes()
        {
            StaticUtils.OutgoingRouteMatch("/", "Home", "Index");
            StaticUtils.OutgoingRouteMatch("/", string.Empty, string.Empty);
            StaticUtils.OutgoingRouteMatch("/", "Home", string.Empty);
            StaticUtils.OutgoingRouteMatch("/", string.Empty, "Index");
            StaticUtils.OutgoingRouteMatch("/Home/Index/32", string.Empty, string.Empty, new { id = "32" });

            StaticUtils.OutgoingRouteMatch("/Account/Logon", "Account", "Logon");

            StaticUtils.OutgoingRouteMatch("/old/1", "Legacy", "GetLegacyUrl", new { legacyUrl = "~/old/1" });
        }
    }
}
