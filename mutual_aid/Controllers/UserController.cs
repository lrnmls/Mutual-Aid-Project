using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting.Internal;
using mutual_aid.DAL;
using mutual_aid.Models;
using mutual_aid.Providers.Auth;

namespace mutual_aid.Controllers
{
    public class UserController : Controller
    {
        private readonly RequestSqlDAO requestDAO;
        private readonly UserSqlDAO userDAO;
        private readonly IAuthProvider authProvider;

        public UserController(RequestSqlDAO requestDAO, UserSqlDAO userDAO, IAuthProvider authProvider)
        {
            this.requestDAO = requestDAO;
            this.userDAO = userDAO;
            this.authProvider = authProvider;
        }

        public IActionResult UserHomePage()
        {
            User user = authProvider.GetCurrentUser();
            return View(user);
        }

        [HttpGet]
        public IActionResult ChangeUserPassword()
        {
            User user = authProvider.GetCurrentUser();
            user = userDAO.GetUser(user.Email);
            return View(user);
        }

        [HttpPost]
        public IActionResult ChangeUserPassword(User user, string Salt, string NewPassword, string Password)
        {
            user = authProvider.GetCurrentUser();
            authProvider.ChangePassword(Password, NewPassword);
            TempData["ChangePasswordSuccess"] = "You've successfully changed your password!";
            return RedirectToAction("UserHomePage", "User", user);
        }

        [HttpGet]
        public IActionResult ChangeUserInfo()
        {
            User user = authProvider.GetCurrentUser();
            return View(user);
        }

        [HttpPost]
        public IActionResult ChangeUserInfo(User user)
        {
            int userId = authProvider.GetCurrentUser().Id;
            userDAO.EditUserInfo(user, userId);
            TempData["ChangeUserInfoSuccess"] = "You've successfully changed your information!";
            return RedirectToAction("UserHomePage", "User", user);
        }
    }
}