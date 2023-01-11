using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
