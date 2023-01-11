using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
