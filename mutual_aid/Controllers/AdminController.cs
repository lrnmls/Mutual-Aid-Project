using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            if (requests.Count == 0)
            {
                TempData["NoRequests"] = "There are currently no requests.";
            }
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
            Request request = new Request();
            AddCounties(request);
            if (AddCounties(request).Counties.Count == 0)
            {
                TempData["NoRequests"] = "There are currently no requests.";
            }
            return View(request);
        }

        [HttpGet]
        public IActionResult ViewAllRequestsByCountyResult(Request request)
        {
            request.SearchResults = requestDAO.GetAllRequestsByCounty(request.County);
            AddCounties(request);
            return View(request);
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