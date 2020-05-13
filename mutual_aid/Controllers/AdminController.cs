using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using mutual_aid.DAL;
using mutual_aid.Models;
using mutual_aid.Models.Account;
using mutual_aid.Providers.Auth;

namespace mutual_aid.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserSqlDAO userDAO;
        private readonly RequestSqlDAO requestDAO;
        private readonly IAuthProvider authProvider;

        public AdminController(UserSqlDAO userDAO, RequestSqlDAO requestDAO, IAuthProvider authProvider)
        {
            this.userDAO = userDAO;
            this.requestDAO = requestDAO;
            this.authProvider = authProvider;
        }

        [HttpGet]
        public IActionResult AdminHomePage()
        {
            User user = authProvider.GetCurrentUser();
            return View(user);
        }

        [HttpGet]
        public IActionResult CreateNewUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.isAdmin)
                {
                    TempData["CreateNewUser"] = "Successfully created new admin user!";
                    authProvider.Register(model.Email, model.Password, role: "admin", model.FirstName, model.LastName, model.PhoneNumber, model.County);
                }
                else
                {
                    TempData["CreateNewUser"] = "Successfully created new user!";
                    authProvider.Register(model.Email, model.Password, role: "user", model.FirstName, model.LastName, model.PhoneNumber, model.County);
                }
                return RedirectToAction("AdminHomePage", "Admin");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ViewAllRequests()
        {
            List<Request> requests = requestDAO.GetAllRequests();
            return View(requests);
        }

        [HttpGet]
        public IActionResult ViewAllRequestDetails(int requestId)
        {
            Request request = requestDAO.GetRequestsByRequestId(requestId);
            return View(request);
        }

        [HttpGet]
        public IActionResult ViewAllRequestsByCounty()
        {
            TempData["NoRequests"] = "There are currently no requests.";
            Request request = new Request();
            AddCounties(request);
            return View(request);
        }

        [HttpGet]
        public IActionResult ViewAllRequestsByCountyResult(Request request)
        {
            request.SearchResults = requestDAO.GetAllRequestsByCounty(request.County);
            AddCounties(request);
            return View(request);
        }

        [HttpGet]
        public IActionResult ViewAllRequestsByDate()
        {
            List<Request> requests = requestDAO.GetAllRequestsOrderByDate();
            return View(requests);
        }

        [HttpGet]
        public IActionResult ViewAllRequestsByLastName()
        {
            List<Request> requests = requestDAO.GetAllRequestsOrderByLastName();
            return View(requests);
        }

        [HttpGet]
        public IActionResult ViewAllPendingRequests()
        {
            List<Request> requests = requestDAO.GetAllPendingRequests();
            return View(requests);
        }

        [HttpGet]
        public IActionResult ViewAllAcceptedRequests()
        {
            List<Request> requests = requestDAO.GetAllAcceptedRequests();
            return View(requests);
        }

        [HttpGet]
        public IActionResult ViewAllCompletedRequests()
        {
            List<Request> requests = requestDAO.GetAllCompletedRequests();
            return View(requests);
        }

        [HttpGet]
        public IActionResult ListEditUsers(int currentUserId)
        {
            List<User> users = new List<User>();
            currentUserId = authProvider.GetCurrentUser().Id;
            users = userDAO.GetAllUsers(currentUserId);
            return View(users);
        }

        [HttpGet]
        public IActionResult EditUserInfo(string userEmail)
        {
            User user = userDAO.GetUser(userEmail);
            return View(user);
        }

        [HttpPost]
        public IActionResult EditUserInfo(User user, int userId)
        {
            userDAO.EditUserInfo(user, userId);
            //TempData["ChangeUserInfoSuccess"] = "You've successfully changed their information!";
            return RedirectToAction("AdminHomePage", "Admin");
        }

        [HttpGet]
        public IActionResult ListEditUsersPassword(int currentUserId)
        {
            List<User> users = new List<User>();
            currentUserId = authProvider.GetCurrentUser().Id;
            users = userDAO.GetAllUsers(currentUserId);
            return View(users);
        }

        [HttpGet]
        public IActionResult EditUserInfoPassword(string userEmail)
        {
            User user = userDAO.GetUser(userEmail);
            return View(user);
        }

        [HttpPost]
        public IActionResult EditUserInfoPassword(int userId, string Salt, string NewPassword, string Password)
        {
            User user = userDAO.GetUserById(userId);
            authProvider.ChangePasswordOfUser(user, Password, NewPassword);
            return RedirectToAction("AdminHomePage", "Admin");
        }

        private Request AddCounties(Request model)
        {
            User user = authProvider.GetCurrentUser();
            List<string> counties = requestDAO.GetCounties(user.Id);
            foreach (string s in counties)
            {
                model.AddCounty(s);
            }
            return model;
        }
    }
}