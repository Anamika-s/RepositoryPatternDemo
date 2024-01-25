using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.IRepo
{
    public interface ICourseRepo
    {
        List<Course> GetAllCourses();
        Course GetCourseById(int id);
        void AddCourse(Course course);
        bool UpdateCourse(Course course, int id);
        bool DeleteCourse(int id);
    }
}
