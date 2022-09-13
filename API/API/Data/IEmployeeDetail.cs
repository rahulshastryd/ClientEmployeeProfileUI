﻿using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Data
{
    public interface IEmployeeDetail
    {
        List<EmployeeDetail> GetEmployeeDetails();
        EmployeeDetail GetEmployeeDetail(int id);
    }
}
