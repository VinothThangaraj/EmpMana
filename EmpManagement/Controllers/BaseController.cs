using System.Web;
using System.Web.Mvc;

namespace EmpManagement.Controllers
{
    /// <summary>
    /// Base Controller
    /// </summary>
    public class BaseController : Controller
    {
        /// <summary>
        /// user ip address
        /// </summary>
        public string ip = string.Empty;
        /// <summary>
        /// current user - user's email id
        /// </summary>
        public string user = string.Empty;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ip = HttpContext.GetOwinContext().Request.RemoteIpAddress;
            user = System.Web.HttpContext.Current.User.Identity.Name;
            base.OnActionExecuting(filterContext);
        }
    }
}