using Microsoft.AspNetCore.Mvc;
using CRUD.Models;
namespace CRUD.Controllers
{
    public class ShoolsController : Controller
    {
        public IActionResult GetAll()
        {
            List<School> Schools = new List<School>()
            {
                new School{ Id = 1 , Name = "first school"},
                new School{ Id = 2 , Name = "Second schools"}
            };
            return View(Schools);
        }
    }
}
