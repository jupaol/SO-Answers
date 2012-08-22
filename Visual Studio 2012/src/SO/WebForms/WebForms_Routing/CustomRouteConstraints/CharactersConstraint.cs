using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace WebForms_Routing.CustomRouteConstraints
{
    public class CharactersConstraint : IRouteConstraint
    {
        public bool Match(
            HttpContextBase httpContext, 
            Route route, 
            string parameterName, 
            RouteValueDictionary values, 
            RouteDirection routeDirection)
        {
            HttpContext.Current.Trace.Warn(parameterName);

            if (!values.ContainsKey(parameterName))
            {
                return false;
            }

            if (values[parameterName] == null)
            {
                return true;
            }

            var extraInfoParameter = values[parameterName].ToString();
            var extraInfo = extraInfoParameter.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            return !extraInfo.Except(new[] { "Leviatans", "Kenfo", "Syilar" }).Any();
        }
    }
}