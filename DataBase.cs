using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class DataBase : IDataBase
    {
        public List<Employee> getAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee
                {
                    Id = i,
                    Name = "Employee " + i,
                    BasicSalary = Random.Shared.Next(1000, 5001),
                    Deductions = Random.Shared.Next(0, 501),
                    Bouns = Random.Shared.Next(0, 1001)
                });
            }
            return employees;
        }

        public List<Student> getAllStudents()
        {
            List<Student> employees = new List<Student>();
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Student
                {
                    Id = i,
                    Name = "Student " + i,
                    SerialNumber = $"s{i}{Random.Shared.Next(10000, 100000)}",
                });
            }
            return employees;
        }

        public List<Course> getAllCourses()
        {
            List<Course> employees = new List<Course>();
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Course
                {
                    Id = i,
                    Name = "Cousre " + i,
                    Level = Convert.ToInt16(Random.Shared.Next(1,5)),
                    Mark = 100,
                });
            }
            return employees;
        }

        public List<Enrollment> getAllEnrollment()
        {
            List<Enrollment> employees = new List<Enrollment>();
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Enrollment
                {
                    EmployeeId = Random.Shared.Next(1,101),
                    CourseId = Random.Shared.Next(1,101),
                    StudentId = Random.Shared.Next(1,101),
                });
            }
            return employees;
        }

        public void Dispose()
        {
        }
    }
}