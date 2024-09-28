namespace ConsoleApp1
{
    public interface ISalaryCalculator
    {
        public delegate bool ShouldCalculate(Employee employee);
        public event EmployeeSalaryCalculatedEventHandler EmployeeSalaryCalculated;
        public event EmployeeSalaryCalculatedAfterIncreasingEventHandler EmployeeSalaryCalculatedAfterIncreasing;

        public delegate void EmployeeSalaryCalculatedEventHandler(Employee employee, int salary);
        public delegate void EmployeeSalaryCalculatedAfterIncreasingEventHandler(string message);
        public void CalculateSalary(List<Employee> employees, ShouldCalculate predicate);
        public void IncreaseSalary(Employee employee, int amount);
    }
}