using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mutual_aid.Models.Account;
using mutual_aid.DAL;
using mutual_aid.Models;
using Microsoft.AspNetCore.Identity;
using mutual_aid.Providers.Auth;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace mutual_aid.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserSqlDAO userDAO;
        private readonly IAuthProvider authProvider;

        public AccountController(UserSqlDAO userDAO, IAuthProvider authProvider)
        {
            this.userDAO = userDAO;
            this.authProvider = authProvider;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var user = authProvider.GetCurrentUser();
            return View(user);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Check that they provided correct credentials
                bool validLogin = authProvider.SignIn(model.Email, model.Password);
                User user = authProvider.GetCurrentUser();
                if (validLogin)
                {
                    if (user.Role == "admin")
                    {
                        return RedirectToAction("AdminHomePage", "Admin");
                    }
                    else
                    {
                        return RedirectToAction("UserHomePage", "User");
                    }
                }
            }
            ViewBag.ErrorLoginMessage = "No account found, please register.";
            return View(model);
        }

        [HttpGet]
        public IActionResult LogOff()
        {
            // Clear user from session
            authProvider.LogOff();

            // Redirect the user where you want them to go after logoff
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(userDAO.GetUser(model.Email) != null)
                {
                    ViewBag.AlreadyExistsMessage = "Email already exists in system, try logging in.";
                }
                else
                {
                    // Redirect the user where you want them to go after registering
                    authProvider.Register(model.Email, model.Password, model.FirstName, model.LastName, model.PhoneNumber, model.County, model.Role);
                    

                    return RedirectToAction("Login", "Account");
                }
            }
            return View(model);
        }
    }
}