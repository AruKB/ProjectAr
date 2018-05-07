using Microsoft.AspNetCore.Mvc;
namespace project.Controllers
{
    public class FormsController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}