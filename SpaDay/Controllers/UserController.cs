using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using SpaDay.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public string UserName { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            AddUserViewModel User = new AddUserViewModel();
            return View(User);
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(AddUserViewModel User)
        {
            if (ModelState.IsValid)
            {
                if(User.Password == User.VerifyPassword)
                {
                    User newUser = new User();
                    UserName = User.UserName;
                    Email = User.Email;
                    Password = User.Password;
                    return View("Index", newUser);
                }
                else
                {
                    ViewBag.error = "Passwords do not match! Try again!";
                    ViewBag.UserName = User.UserName;
                    ViewBag.Email = User.Email;
                    return View("Add", User);
                }
            }

            return View("add", User);
        }

    }
}
