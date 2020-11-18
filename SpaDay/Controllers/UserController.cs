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

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.UserName = newUser.UserName;
                return View("Index");
            }
            else
            {
                ViewBag.Error = "Passwords must match!";
                ViewBag.UserName = newUser.UserName;
                ViewBag.Email = newUser.Email;

                return View("Add");
            }

        }
    }
}
