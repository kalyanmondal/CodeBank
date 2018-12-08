using EmployeeDataAccess;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPIDemo.Helper
{
    public class BasicAuthenticationAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string userName = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken)).Split(':')[0];
                string password = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken)).Split(':')[1];

                if(this.Login(userName, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(userName), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }

        private bool Login(string userName, string password)
        {
            using (EmployeeDBContext dBContext = new EmployeeDBContext())
            {
                return dBContext.Users.Any(user => user.UserName.Equals(userName, StringComparison.OrdinalIgnoreCase) && user.Password == password);
            }
        }
    }
}