using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ConsoleApp1.ICourseService;

namespace ConsoleApp1
{
    public class CourseService : ICourseService
    {
        private readonly IDataBase _database;

        public CourseService(IDataBase database)
        {
            _database = database;
        }

        //you can add many methods here but should be related to the Course
        //to acheive the single responibilites 
        public List<Course> getAllCoursesWith(List<Course> courses, FilteringTheCourses filteringTheCourses)
        {
            return courses.Where(filteringTheCourses.Invoke).ToList();
        }
    }
}