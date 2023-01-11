using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
