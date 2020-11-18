using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmpManagement.Contracts.Models
{
    public class MessageResult
    {
        public string Title { get; set; }
        public string Message { get; set; }

        public string Errors { get; set; }
        public object Result { get; set; }

    }
    public class ApiResponseModel
    {
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public string SuccessMessage { get; set; }
    }

    public class ErrorModel
    {
        public string error_code { get; set; }
        public string error_message { get; set; }
    }

    public class GenericResponse : ApiResponseModel
    {
        public dynamic Data { get; set; }
        public bool IsSuccess { get; set; }
        public int StatusCode { get; set; }
        //public HttpResponseMessage Content { get; set; }
    }

}