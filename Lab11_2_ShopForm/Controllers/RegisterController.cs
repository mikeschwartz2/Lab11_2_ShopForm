using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab11_2_ShopForm.wwwroot
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(string fname, string lname, string email, string phone, string uname, string password)
        {
            ViewData["name"] = fname + " " + lname;
            ViewData["email"] = email;
            ViewData["passwod"] = password;
            ViewData["Phone"] = phone;
            ViewData["username"] = uname;
            return View();
        }
    }
}