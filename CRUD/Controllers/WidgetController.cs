using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class WidgetController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
