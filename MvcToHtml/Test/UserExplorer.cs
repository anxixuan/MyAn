using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcToHtml.Test
{
    public class UserExplorer:IRouteConstraint
    {
        string requiredUserAgent;
        public UserExplorer(string agentParam) {
            requiredUserAgent = agentParam;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext.Request.UserAgent != null && httpContext.Request.UserAgent.Contains(requiredUserAgent);
        }
    }
}