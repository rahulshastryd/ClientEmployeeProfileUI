using API.Data;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.SQLData
{
    public class SQLPerformanceHistory : IPerformanceHistory
    {
        private readonly EmployeeContext _employeeContext;

        public SQLPerformanceHistory(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<PerformanceHistory> performanceHistory()
        {
            return _employeeContext.PerformanceDetails.ToList();
        }
    }
}
