using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement.Contracts.Models
{
    public class BaseDto
    {
        [JsonIgnore]
        public string Message { get; set; }

        [JsonIgnore]
        public bool Status { get; set; }
    }
}
