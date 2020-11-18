using System.Web.Mvc;
using EmpManagement.Contracts.Resources;

namespace EmpManagement.Controllers
{
    /// <summary>
    /// Error Controller - To Handle Error 
    /// </summary>
    public class ErrorController : Controller
    {
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        // GET: Error
        public ActionResult Index()
        {
            ViewBag.ErrorMessage = ErrorMessage.INTERNAL_SERVER_ERROR;
            return View();
        }
        /// <summary>
        /// BadRequest errors
        /// </summary>
        /// <returns></returns>
        public ActionResult BadRequest()
        {
            ViewBag.ErrorMessage = ErrorMessage.BAD_REQUEST;
            return View();
        }
        /// <summary>
        /// PageNotFound errors
        /// </summary>
        /// <returns></returns>
        public ActionResult PageNotFound()
        {
            ViewBag.ErrorMessage = ErrorMessage.PAGE_NOT_FOUND;
            return View();
        }
    }
}