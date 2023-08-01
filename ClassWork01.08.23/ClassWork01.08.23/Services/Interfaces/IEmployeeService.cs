using ClassWork01._08._23.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork01._08._23.Services.Interfaces
{
    internal interface IEmployeeService
    {
        List<Employee> GetAll();

        List<Employee> FilterBySalary(decimal firstSalary,decimal secondSalary, List<Employee> employees);

    }
}
