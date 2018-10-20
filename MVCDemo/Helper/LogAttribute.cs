using log4net;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDemo.Helper
{
    public class LogAttribute : ActionFilterAttribute
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogAttribute));

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            log.Debug(generateMessage("OnActionExecuted", filterContext.RouteData));
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            log.Debug(generateMessage("OnActionExecuting", filterContext.RouteData));
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            log.Debug(generateMessage("OnResultExecuted", filterContext.RouteData));
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            log.Debug(generateMessage("OnResultExecuting ", filterContext.RouteData));
        }

        private string generateMessage(string methodName, RouteData routeData)
        {
            var controllerName = routeData.Values["controller"];
            var actionName = routeData.Values["action"];
            return String.Format("{0}- controller:{1} action:{2}", methodName, controllerName, actionName);
        }
    }
}