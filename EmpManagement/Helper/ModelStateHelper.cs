using Newtonsoft.Json;
using EmpManagement.Service.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ModelBinding;

namespace EmpManagement.Helper
{
    /// <summary>
    /// ModelStateHelper
    /// </summary>
    public static class ModelStateHelper
    {
        /// <summary>
        /// ModelStateConversion
        /// </summary>
        /// <param name="modelState"></param>
        /// <returns></returns>
        public static string ErrorMessage(this ModelStateDictionary modelState)
        {
            try
            {
                var errorList = modelState.Values.SelectMany(m => m.Errors)
                                                .Select(e => string.IsNullOrEmpty(e.ErrorMessage)
                                                ?
                                                (e.Exception == null ? string.Empty : e.Exception.Message) :
                                                e.ErrorMessage)
                                     .ToList();
                if (errorList.Any())
                {
                    var modelStateJson = JsonConvert.SerializeObject(errorList);
                    return modelStateJson;
                }
                else { return string.Empty; }
            }
            catch (Exception ex) {
                ErrorLog.HandleException(ex);
                return string.Empty;
            }
        }
    }
}