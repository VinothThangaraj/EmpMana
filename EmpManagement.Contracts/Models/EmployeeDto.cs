using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpManagement.Contracts.Models
{
   
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string IncentiveYear { get; set; }
        public int Incentivesum { get; set; }
    }

   
}
