namespace ConsoleApp1
{
    public interface IDataBase : IDisposable
    {
        public List<Employee> getAllEmployees();

        public List<Student> getAllStudents();

        public List<Course> getAllCourses();

        public List<Enrollment> getAllEnrollment();
    }
}