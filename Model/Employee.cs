using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Employee
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public int BasicSalary { get; set; }
        public int Deductions { get; set; }
        public int Bouns { get; set; }

        public override string ToString()
        {
            return $"[{Id}] Name: {Name} Has Salary {BasicSalary} with bouns {Bouns}";
        }
    }
}