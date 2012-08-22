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
                //if the current constraint does not containe the parameter name we return false
                //since there's nothing to validate
                return false;
            }

            if (values[parameterName] == null)
            {
                // since the parameter is optional we return true here
                return true;
            }

            var extraInfoParameter = values[parameterName].ToString();
            var extraInfo = extraInfoParameter.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);

            return !extraInfo.Except(new[] { "Leviatans", "Kenfo", "Syilar" }).Any();
        }
    }
}