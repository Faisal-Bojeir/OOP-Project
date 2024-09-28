using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public delegate bool ShouldCalculate(Employee employee);
        public event ISalaryCalculator.EmployeeSalaryCalculatedEventHandler? EmployeeSalaryCalculated;
        public event ISalaryCalculator.EmployeeSalaryCalculatedAfterIncreasingEventHandler? EmployeeSalaryCalculatedAfterIncreasing;
        public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);

        private int CalculateSalaryAfterIncreasing(int salary, int amount) 
        {
            return salary += amount;
        }

        public void CalculateSalary(List<Employee> employees, ISalaryCalculator.ShouldCalculate predicate)
        {
            foreach (Employee employee in employees)
            {
                if(predicate(employee)) {
                    var salary = employee.BasicSalary + employee.Bouns - employee.Deductions;
                    EmployeeSalaryCalculated?.Invoke(employee, salary);
                }
            }
        }

        public void IncreaseSalary(Employee employee, int amount)
        {
            EmailSender.NotifyEmployee($"Dear, {employee.Name}\n we accept your request to increase your salary from {employee.BasicSalary} to {CalculateSalaryAfterIncreasing(employee.BasicSalary, amount)}");
            EmployeeSalaryCalculatedAfterIncreasing?.Invoke("Succefully");
        }
    }
}