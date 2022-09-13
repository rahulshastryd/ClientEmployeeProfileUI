using API.Data;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.SQLData
{
    public class SQLQualificationAndPerformanceRating : IQualificationAndPerformanceRating
    {
        private readonly EmployeeContext _employeeContext;

        public SQLQualificationAndPerformanceRating(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }
        public List<QualificationAndPerformanceRating> qpRating()
        {
            return _employeeContext.Ratings.ToList();
        }
    }
}
