using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System.Configuration;
using EmpManagement.Contracts;
using Newtonsoft.Json;
using System.Web.Http.Description;
using ErrorLog = EmpManagement.Service.Helper.ErrorLog;
using Swashbuckle.Swagger.Annotations;
using System.Net;
using EmpManagement.Helper;
using EmpManagement.Contracts.Models;
using EmpManagement.Contracts.Resources;
using System.Linq;
using System.Data.Entity;
using EmpManagement.Service;
using EmpManagement.Service.Helper;
using Microsoft.Ajax.Utilities;

namespace EmpManagement.Controllers
{
    /// <summary>
    /// Account Controller
    /// </summary>
    //    [CustomAuthorize]
    [RoutePrefix("api/Account")]
    public class AccountController 
    {
        private const string LocalLoginProvider = "Local";
        public EmployeeService userService = new EmployeeService();

        /// <summary>
        /// AccountController constructor
        /// </summary>
        public AccountController()
        {
        }

       
      
       

    }
}