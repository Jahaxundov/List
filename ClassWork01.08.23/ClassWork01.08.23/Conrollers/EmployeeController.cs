using ClassWork01._08._23.Models;
using ClassWork01._08._23.Services;
using ClassWork01._08._23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork01._08._23.Conrollers
{
    internal class EmployeeController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
            var employyes = _employeeService.GetAll();
            foreach (var employee in employyes)
            {
                string result = $"{employee.Id} - {employee.FullName} - {employee.Age} - {employee.Salary} ";
                Console.WriteLine(result);
            }
        }

        public void FilterBySalary()
        {
            decimal first = 2400;
            decimal second = 4000;
            List<Employee> employees = _employeeService.GetAll();

            var filteredEmployee = _employeeService.FilterBySalary(first, second, employees);
            foreach (var item in filteredEmployee)
            {
                string result = $"{item.Id} - {item.FullName} - {item.Age} - {item.Salary} ";
                Console.WriteLine(result);
            }


        }
    }
}
