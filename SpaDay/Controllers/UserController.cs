using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/user/add")]
        public IActionResult SignUp(User user, string verify)
        {
            if (user.Password == verify)
            {
                ViewBag.user = user;
                return View("Index");
            }
            else
            {
                ViewBag.user = user;
                ViewBag.message = "passwords don't match!";
                return View("add");
            }
        }
    }
}
