using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult signin()
        {
            return View();
        }
        public IActionResult signup()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Blank()
        {
            return View();
        }
    }
}
