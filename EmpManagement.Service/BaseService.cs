using EmpManagement.Contracts;
using System;

namespace EmpManagement.Service
{
    public class BaseService : IDisposable
    {
        protected EmployeeEntities Db { get; set; }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Db.Dispose();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
