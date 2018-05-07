using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using project.Models;
namespace project.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }        
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
        public IActionResult User (){
            User user = new User();
            user.name = "Aruzhan";
            user.surname = "Kabdusheva";
            user.age = 19;
            return View(user);
        }
    }
}