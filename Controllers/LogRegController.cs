using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using System.Linq;
using System.Collections.Generic;
using System.Web;
using project.EmpDataContext;
using project.Models;

namespace project.Controllers
{
    public class LogRegController:Controller
    {
        private readonly AppDataContext context;
        public LogRegController(AppDataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Users model)
        {
            if(!ModelState.IsValid)
                return View(model);
            context.Add(model);
            context.SaveChanges();
            return RedirectToAction("login");
        }
        //[HttpPost]
        //public JsonResult doesUserName

    }
}