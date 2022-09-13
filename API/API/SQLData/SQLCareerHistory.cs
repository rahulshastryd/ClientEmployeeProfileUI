using API.Data;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.SQLData
{
    public class SQLCareerHistory : ICareerHistory
    {
        private readonly EmployeeContext _employeeContext;

        public SQLCareerHistory(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<CareerHistory> careerHistory()
        {
            return _employeeContext.CareerDetails.ToList();
        }
    }
}
