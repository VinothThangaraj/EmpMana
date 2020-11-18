using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using EmpManagement.Service.Helper;
using System.Linq;
using EmpManagement.Contracts.Models;
using EmpManagement.Contracts;

namespace EmpManagement.Service
{
    /// <summary>
    ///UserService
    /// </summary>
    public class EmployeeService : BaseService
    {
        private readonly string ip = string.Empty;

        public EmployeeService(string IP = null)
        {
            this.ip = IP;
        }

        private readonly EmployeeEntities db = new EmployeeEntities();

        /// <summary>
        /// GetEmployeeAppraisal
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public async Task<List<EmployeeDto>> GetAppraisalByYear(string year)
        {
            try
            {
                using (var context = new EmployeeEntities())
                {
                    var data = context.EmployeeIncentives.Where(d => d.IncentiveYear == year)
                        .Select(k => new { k.EmployeeId, k.IncentiveYear, k.Incentive, k.Employee.FirstName, k.Employee.LastName, k.Employee.EmployeeCode })
                        .GroupBy(x => new { x.EmployeeId, x.IncentiveYear, x.FirstName, x.LastName, x.EmployeeCode }, (key, group) => new EmployeeDto
                        {
                            IncentiveYear = key.IncentiveYear,
                            Id = key.EmployeeId,
                            Incentivesum = group.Sum(k => k.Incentive),
                            FirstName = key.FirstName,
                            LastName = key.LastName,
                            EmployeeCode = key.EmployeeCode
                        }).ToListAsync();
                    return await data;
                }
            }
            catch (Exception e)
            {
                ErrorLog.HandleException(e);
                return null;
            }
        }


        /// <summary>
        /// GetAppraisalByEmp
        /// </summary>
        /// <param name="empCode"></param>
        /// <returns></returns>
        public async Task<List<EmployeeDto>> GetAppraisalByEmp(string empCode)
        {
            try
            {
                using (var context = new EmployeeEntities())
                {
                    var data = context.EmployeeIncentives.Where(d => d.Employee.EmployeeCode == empCode)
                        .Select(k => new { k.EmployeeId, k.IncentiveYear, k.Incentive, k.Employee.FirstName, k.Employee.LastName, k.Employee.EmployeeCode })
                        .GroupBy(x => new { x.EmployeeId, x.IncentiveYear, x.FirstName, x.LastName, x.EmployeeCode }, (key, group) => new EmployeeDto
                        {
                            IncentiveYear = key.IncentiveYear,
                            Id = key.EmployeeId,
                            Incentivesum = group.Sum(k => k.Incentive),
                            FirstName = key.FirstName,
                            LastName = key.LastName,
                            EmployeeCode = key.EmployeeCode
                        }).ToListAsync();
                    return await data;
                }
            }
            catch (Exception e)
            {
                ErrorLog.HandleException(e);
                return null;
            }
        }





    }
}
