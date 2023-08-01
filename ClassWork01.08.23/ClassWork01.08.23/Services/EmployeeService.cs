using ClassWork01._08._23.Models;
using ClassWork01._08._23.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork01._08._23.Services
{
    internal class EmployeeService : IEmployeeService
    {
        public List<Employee> FilterBySalary(decimal firstSalary, decimal secondSalary,List<Employee> employees)
        {
            return employees.FindAll(m => m.Salary > firstSalary && m.Salary < secondSalary);
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new();
            {
                list.Add(new Employee {Id = 1,FullName ="Ismayil Afandizade",  Age =29, Salary =2000});
                list.Add(new Employee { Id = 2, FullName = "Samir Qehremanov", Age = 25, Salary = 2500 });
                list.Add(new Employee { Id = 3, FullName = "Fidan Besirova", Age = 22, Salary = 3000 });
                list.Add(new Employee { Id = 4, FullName = "Kubra Mammedova", Age = 25, Salary = 2400 });

                return list;
            }
        }    
    }
}
