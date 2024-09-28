namespace ConsoleApp1
{

    class Program
    {
        public static void Main(string[] args)
        {   
            List<Course> courses;
            using(IDataBase dataBase = DataBaseFactory.Create()) 
            {
                ICourseService courseService= new CourseService(dataBase);
                courses = courseService.getAllCoursesWith(dataBase.getAllCourses(), c => c.Id >= 10);
            }

            foreach(Course course in courses)
            {
                System.Console.WriteLine($"Id [{course.Id}] for course [{course.Name}], Max Mark [{course.Mark}] for level [{course.Level}]");
            }
        }

        private static void EmployeeSalaryCalculatedAfterIncreasing(string message)
        {
            System.Console.WriteLine($"Status: {message}");
        }
    }
}