using RepositoryPatternDemo.IRepo;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repo
{
    public class CourseRepo1 : ICourseRepo
    {
        public void AddCourse(Course course)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAllCourses()
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCourse(Course course, int id)
        {
            throw new NotImplementedException();
        }
    }
}
