using CoffeeShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult formreg(Member newuser)
        {
            if (newuser.password != newuser.confirm)
            {
                message.error = "Please make sure to enter the exact password in the confirm password field.";
                return RedirectToAction("Invalid");
            }
            else
            {
                foreach (Member usr in Member.AllUsers)
                {
                    if(usr.email == newuser.email)
                    {
                        message.error = "Please choose another email. This email has already been used.";
                        return RedirectToAction("Invalid");
                    }
                }
                Member.AllUsers.Add(newuser);
                return RedirectToAction("UserList");

            }
        }
        public IActionResult Invalid (Member invalid, string error)
        {
            return View(error);
        }
        public IActionResult UserList()
        {
            return View(Member.AllUsers);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
