using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class EmployeeService
    { 
        public static Employee GetEmployee(this List<Employee> employees, int id)
        {
            return employees.SingleOrDefault(e => e.Id == id)!;
        }
    }
}