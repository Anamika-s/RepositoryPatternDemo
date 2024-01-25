using RepositoryPatternDemo.Context;
using RepositoryPatternDemo.IRepo;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repo
{
    public class CourseRepo : ICourseRepo
    {
        CourseDbContext _context;
        public CourseRepo(CourseDbContext context)
        {
            _context = context;

        }
        public void AddCourse(Course course)
        { _context.Courses.Add(course);
            _context.SaveChanges();

        }

        public bool DeleteCourse(int id)
        {
            var course = GetCourseById(id);
                if (course != null) {
                _context.Courses.Remove(course);
                _context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(x => x.CourseId == id);
        }

        public bool UpdateCourse(Course course, int id)
        {
            var obj = GetCourseById(id);
            if(obj!=null)
            {
                return true;
            }
            return false;
        }
    }
}
