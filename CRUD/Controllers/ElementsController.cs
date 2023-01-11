using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class ElementsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Typography()
        {
            return View();
        }

        public IActionResult OtherElements()
        {
            return View();
        }
    }
}
