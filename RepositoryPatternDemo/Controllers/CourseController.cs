using Microsoft.AspNetCore.Mvc;
using RepositoryPatternDemo.IRepo;
using RepositoryPatternDemo.Models;
//using RepositoryPatternDemo.Repo;

namespace RepositoryPatternDemo.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepo _repo;
        public CourseController(ICourseRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            
            return View(_repo.GetAllCourses());
        }

        public IActionResult Details(int id) {
            return View(_repo.GetCourseById(id));
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Course course)
        {
            _repo.AddCourse(course);
            return RedirectToAction("Index");   

        }


    }
}
