using API.Data;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.SQLData
{
    public class SQLEmployeeDetail : IEmployeeDetail
    {
        private readonly EmployeeContext _employeeContext;

        public SQLEmployeeDetail(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public EmployeeDetail GetEmployeeDetail(int id)
        {
            return _employeeContext.Employee.FirstOrDefault(x => x.ID == id);
        }



        public List<EmployeeDetail> GetEmployeeDetails()
        {
            return _employeeContext.Employee.ToList();
        }
    }
}
