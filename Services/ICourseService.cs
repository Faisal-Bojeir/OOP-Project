namespace ConsoleApp1
{
    public interface ICourseService
    {
        delegate bool FilteringTheCourses(Course course);
        List<Course> getAllCoursesWith(List<Course> courses, FilteringTheCourses filteringTheCourses);
    }
}