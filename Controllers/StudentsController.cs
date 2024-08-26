using Microsoft.AspNetCore.Mvc;

namespace StudentCotnroller.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult getAll()
        {
            return View(getAll);
        }
        public IActionResult create()
        {
            return View(create);
        }
        public IActionResult update()
        {
            return View(update);
        }
        public IActionResult delet()
        {
            return View(delet);
        }
    }
}
