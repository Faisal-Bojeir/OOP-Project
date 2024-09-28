namespace ConsoleApp1
{
    public class SalaryFactory 
    {
        public static ISalaryCalculator Create()
        {
            return new SalaryCalculator();
        }
    }
}