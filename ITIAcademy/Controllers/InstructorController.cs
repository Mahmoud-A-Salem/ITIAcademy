using ITIAcademy.Data;
using ITIAcademy.Models;
using Microsoft.AspNetCore.Mvc;

namespace ITIAcademy.Controllers
{
    public class InstructorController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            List<Instructor>? instructorsList = 
                context.Instructors.ToList();
            return View("Index", instructorsList);
        }

        public IActionResult Details(int id)
        {
            Instructor? instructor =
                context.Instructors.FirstOrDefault(i => i.Id == id);

            return View("Details", instructor);
        }
    }
}
