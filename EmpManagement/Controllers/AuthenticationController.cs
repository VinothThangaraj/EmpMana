using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using Microsoft.AspNet.Identity;
using EmpManagement.Models;
using System.Threading.Tasks;
using EmpManagement.Contracts;
using EmpManagement.Service.Helper;
using EmpManagement.Contracts.Resources;

namespace EmpManagement.Controllers
{
    /// <summary>
    /// Authentication Controller
    /// </summary>
    public class AuthenticationController : Controller
    {
        /// <summary>
        /// AuthenticationController constructor
        /// </summary>
        public AuthenticationController()
        {

        }
       
        private EmployeeEntities db = new EmployeeEntities();
        // GET: Authentication
        /// <summary>
        /// Login
        /// </summary>
        /// <returns></returns>
        public ActionResult Login()
        {
            return View();
        }
   
       
    }
}
