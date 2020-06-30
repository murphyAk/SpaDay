using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            User newUser = new User();
            return View();
        }

        public IActionResult Add()
        {
            AddUserViewModel userInfo = new AddUserViewModel();
            return View(userInfo);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult Add(AddUserViewModel userInfo)
        {
            if (ModelState.IsValid)
            {

                User newUser = new User
                {
                    Username = userInfo.Username,
                    Email = userInfo.Email,
                    Password = userInfo.Password
                };

                return View("Index", newUser);

            }
            else
            {
                return View("Add", userInfo);
            }
        }

    }
}
