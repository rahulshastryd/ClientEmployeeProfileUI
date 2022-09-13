using API.Data;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.SQLData
{
    public class SQLPreviousEmployment : IPreviousEmployment
    {
        private readonly EmployeeContext _employeeContext;

        public SQLPreviousEmployment(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<PreviousEmployment> preiousEmployment()
        {
            return _employeeContext.PreviousJob.ToList();
        }
    }
}
