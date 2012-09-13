using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FluentAssertions;
using System.Web.Routing;
using MVC3_1;
using System.Web.Mvc;

namespace MVC3_1Tests
{
    public static class StaticUtils
    {
        private static HttpContextBase GetHttpContext(string targetUrl = null, string httpMethod = "GET")
        {
            var request = new Mock<HttpRequestBase>();
            request.SetupGet(x => x.AppRelativeCurrentExecutionFilePath).Returns(() => targetUrl);
            request.SetupGet(x => x.HttpMethod).Returns(() => httpMethod);
            request.SetupGet(x => x.UserAgent).Returns(() => "IE");

            var response = new Mock<HttpResponseBase>();
            response.Setup(x => x.ApplyAppPathModifier(It.IsAny<string>())).Returns<string>(x => x);

            var context = new Mock<HttpContextBase>();
            context.SetupGet(x => x.Request).Returns(() => request.Object);
            context.SetupGet(x => x.Response).Returns(() => response.Object);

            return context.Object;
        }

        private static bool TestIncomingRouteResult(RouteData routeData, string controller, string action, object propertySet = null)
        {
            Func<object, object, bool> compare = (x, y) => StringComparer.InvariantCultureIgnoreCase.Compare(x, y) == 0;

            var result = compare(routeData.Values["controller"], controller) && compare(routeData.Values["action"], action);

            if (propertySet != null)
            {
                var propertiesInfo = propertySet.GetType().GetProperties();

                foreach (var item in propertiesInfo)
                {
                    if (!(routeData.Values.ContainsKey(item.Name) && compare(routeData.Values[item.Name], item.GetValue(propertySet, null))))
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public static void TestRouteMatch(string url, string controller, string action, object routeParameters = null, string httpMethod = "GET")
        {
            var routes = new RouteCollection();

            MvcApplication.RegisterRoutes(routes);

            var result = routes.GetRouteData(GetHttpContext(url, httpMethod));
            result.Should().NotBeNull();

            var routeRes = TestIncomingRouteResult(result, controller, action, routeParameters);
            routeRes.Should().BeTrue();
        }

        public static void TestRouteFail(string url, string httpMethod = "GET")
        {
            var routes = new RouteCollection();

            MvcApplication.RegisterRoutes(routes);

            var routeResult = routes.GetRouteData(GetHttpContext(url, httpMethod));
            var res = routeResult == null || routeResult.Route == null;

            res.Should().BeTrue();
        }

        public static void OutgoingRouteMatch(string url, string controller, string action, object routeParameters = null)
        {
            var routes = new RouteCollection();
            var context = new RequestContext(GetHttpContext(), new RouteData());
            RouteValueDictionary routeValueDictionary = null;

            if (routeParameters != null)
            {
                routeValueDictionary = new RouteValueDictionary(routeParameters);
            }

            MvcApplication.RegisterRoutes(routes);

            var result = UrlHelper.GenerateUrl(null, action, controller, routeValueDictionary, routes, context, true);

            result.Should().Be(url);
        }
    }
}
