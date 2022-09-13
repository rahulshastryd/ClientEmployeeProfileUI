using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace API.Controllers
{
    public class EmployeeDetailController : ControllerBase
    {
        private readonly IEmployeeDetail _employeeData;

        public EmployeeDetailController(IEmployeeDetail employeeData)
        {
            _employeeData = employeeData;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees()
        {
            return Ok(_employeeData.GetEmployeeDetails());
        }
        public IActionResult GetDetail(int id)
        {
            var employee = _employeeData.GetEmployeeDetail(id);
            if (employee != null)
            {
                return Ok(_employeeData.GetEmployeeDetail(id));
            }
            else
            {
                return NotFound($"Employee with {id} not found!!!");
            }
        }

    }
}
