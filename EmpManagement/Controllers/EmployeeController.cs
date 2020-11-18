using EmpManagement.Service;
using EmpManagement.Contracts.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using EmpManagement.Contracts.Resources;
using EmpManagement.Service.Helper;

namespace EmpManagement.Controllers
{
    /// <summary>
    /// EmployeeController
    /// </summary>
    [System.Web.Http.RoutePrefix("api/Employee")]
    public class EmployeeController : ApiController
    {
        private EmployeeService employeeService;

        /// <summary>
        /// EmployeeController Constructor
        /// </summary>
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        /// <summary>
        /// This api is used to get Employee Incentives by year 
        /// </summary>
        /// <param name="year">Mandatory</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{year}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(GenericResponse))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public async Task<IHttpActionResult> ReadEmployeesIncentives(string year)
        {
            GenericResponse apiResponseModel = new GenericResponse();
            try
            {
                if (String.IsNullOrEmpty(year))
                {
                    apiResponseModel.IsSuccess = false;
                    apiResponseModel.StatusCode = (int)HttpStatusCode.BadRequest;
                    apiResponseModel.Message = ErrorMessage.BAD_REQUEST;
                    return Ok(apiResponseModel);
                }
                var result = await employeeService.GetAppraisalByYear(year);
                if (result == null)
                {
                    apiResponseModel.Message = ErrorMessage.DATA_NOT_FOUND;
                    apiResponseModel.IsSuccess = false;
                    apiResponseModel.StatusCode = (int)HttpStatusCode.OK;
                    return Ok(apiResponseModel);
                }
                apiResponseModel.IsSuccess = true;
                apiResponseModel.Data = result;
                apiResponseModel.StatusCode = (int)HttpStatusCode.OK;
                return Ok(apiResponseModel);
            }
            catch (Exception ex)
            {
                ErrorLog.HandleException(ex);
                apiResponseModel.IsSuccess = false;
                apiResponseModel.StatusCode = (int)HttpStatusCode.InternalServerError;
                apiResponseModel.Message = ErrorMessage.INTERNAL_SERVER_ERROR;
                return Ok(apiResponseModel);
            }
        }

        /// <summary>
        /// This api is used to get Employee Incentives by EmpCode
        /// </summary>
        /// <param name="empCode">Mandatory</param>
        /// <returns></returns>
        [HttpGet]
        [Route("{empCode}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(GenericResponse))]
        [SwaggerResponse(HttpStatusCode.BadRequest, Type = typeof(GenericResponse))]
        [SwaggerResponse(HttpStatusCode.InternalServerError, Type = typeof(GenericResponse))]
        public async Task<IHttpActionResult> ReadEmployeeIncentive(string empCode)
        {
            GenericResponse apiResponseModel = new GenericResponse();
            try
            {
                if (String.IsNullOrEmpty(empCode))
                {
                    apiResponseModel.IsSuccess = false;
                    apiResponseModel.StatusCode = (int)HttpStatusCode.BadRequest;
                    apiResponseModel.Message = ErrorMessage.BAD_REQUEST;
                    return Ok(apiResponseModel);
                }
                var result = await employeeService.GetAppraisalByEmp(empCode);
                if (result == null)
                {
                    apiResponseModel.Message = ErrorMessage.DATA_NOT_FOUND;
                    apiResponseModel.IsSuccess = false;
                    apiResponseModel.StatusCode = (int)HttpStatusCode.OK;
                    return Ok(apiResponseModel);
                }
                apiResponseModel.IsSuccess = true;
                apiResponseModel.Data = result;
                apiResponseModel.StatusCode = (int)HttpStatusCode.OK;
                return Ok(apiResponseModel);
            }
            catch (Exception ex)
            {
                ErrorLog.HandleException(ex);
                apiResponseModel.IsSuccess = false;
                apiResponseModel.StatusCode = (int)HttpStatusCode.InternalServerError;
                apiResponseModel.Message = ErrorMessage.INTERNAL_SERVER_ERROR;
                return Ok(apiResponseModel);
            }
        }


    }
}