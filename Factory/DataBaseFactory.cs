namespace ConsoleApp1
{
    public class DataBaseFactory 
    {
        public static IDataBase Create()
        {
            return new DataBase();
        }
    }
}