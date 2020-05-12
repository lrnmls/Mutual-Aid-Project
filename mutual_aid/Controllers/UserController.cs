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
            return RedirectToAction("UserHomePage", "User", user);
        }

        //[HttpGet]
        //public IActionResult SubmitRequest()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult SubmitRequest(Request request, int userId)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    userId = user.Id;
        //    requestDAO.AddRequest(request, userId);
        //    return RedirectToAction("UserHomePage", "User");
        //}

        //[HttpGet]
        //public IActionResult ViewRequests(Request request)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    List<Request> requests = requestDAO.GetAllRequests(user.Id);
        //    return View(requests);
        //}

        //[HttpGet]
        //public IActionResult ViewRequestDetails(int requestId)
        //{
        //    Request request = requestDAO.GetRequestsByRequestId(requestId);
        //    return View(request);
        //}

        //[HttpGet]
        //public IActionResult ViewRequestsByCounty()
        //{
        //    Request request = new Request();
        //    AddCounties(request);
        //    return View(request);
        //}

        //[HttpGet]
        //public IActionResult ViewRequestsByCountyResult(Request request)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    request.SearchResults = requestDAO.GetRequestByCounty(request.County, user.Id);
        //    AddCounties(request);
        //    return View(request);
        //}

        //[HttpGet]
        //public IActionResult ViewMyRequests(int userId)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    userId = user.Id;
        //    List<Request> requests = requestDAO.GetRequestsByUserId(userId);
        //    if (requests.Count == 0)
        //    {
        //        ViewBag.NoRequestsMessage = "There are currently no requests!";
        //    }
        //    return View(requests);
        //}

        //[HttpPost]
        //public IActionResult ViewMyRequests(int requestId, int userId)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    userId = user.Id;
        //    requestDAO.DeleteRequest(requestId);
        //    List<Request> requests = requestDAO.GetRequestsByUserId(userId);
        //    return View(requests);
        //}


        //[HttpGet]
        //public IActionResult ViewMyRequestDetails(int requestId)
        //{
        //    Request request = requestDAO.GetRequestsByRequestId(requestId);
        //    return View(request);
        //}

        ////[HttpGet]
        ////public IActionResult AcceptedRequest(int requestId)
        ////{
        ////    User user = authProvider.GetCurrentUser();
        ////    Request request = new Request();
        ////    request.Id = requestId;
        ////    return View();
        ////}

        //[HttpPost]
        //public IActionResult AcceptedRequest(int requestId, int acceptedUserId, string acceptedUserFirstName, string acceptedUserLastName, string acceptedUserEmail, string acceptedUserPhoneNumber)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    acceptedUserId = user.Id;
        //    acceptedUserFirstName = user.FirstName;
        //    acceptedUserLastName = user.LastName;
        //    acceptedUserEmail = user.Email;
        //    acceptedUserPhoneNumber = user.PhoneNumber;
        //    requestDAO.AddAcceptedRequest(requestId, acceptedUserId, acceptedUserFirstName, acceptedUserLastName, acceptedUserEmail, acceptedUserPhoneNumber);
        //    Request request = requestDAO.GetRequestsByRequestId(requestId);
        //    return View(request);
        //}

        //[HttpGet]
        //public IActionResult ViewIncompleteRequests()
        //{
        //    User user = authProvider.GetCurrentUser();
        //    int userId = user.Id;
        //    List<Request> requests = requestDAO.IncompleteRequestsByAcceptedUser(userId);
        //    if (requests.Count == 0)
        //    {
        //        ViewBag.NoRequestsMessage = "You have no incomplete requests.";
        //    }
        //    return View(requests);
        //}

        //[HttpPost]
        //public IActionResult ViewIncompleteRequests(int requestId, int acceptedUserId, string acceptedUserFirstName, string acceptedUserLastName, string acceptedUserEmail, string acceptedUserPhoneNumber)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    acceptedUserId = user.Id;
        //    acceptedUserFirstName = user.FirstName;
        //    acceptedUserLastName = user.LastName;
        //    acceptedUserEmail = user.Email;
        //    acceptedUserPhoneNumber = user.PhoneNumber;
        //    requestDAO.AddCompletedRequest(requestId, acceptedUserId, acceptedUserFirstName, acceptedUserLastName, acceptedUserEmail, acceptedUserPhoneNumber);
        //    return RedirectToAction("CompletedRequestConfirmation", "User");
        //}

        //[HttpGet]
        //public IActionResult ViewIncompleteRequestDetails(int requestId)
        //{
        //    Request request = requestDAO.GetRequestsByRequestId(requestId);
        //    return View(request);
        //}

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
            return RedirectToAction("UserHomePage", "User", user);
        }

        //[HttpGet]
        //public IActionResult CompletedRequestConfirmation()
        //{
        //    return View();
        //}

        //private Request AddCounties(Request model)
        //{
        //    User user = authProvider.GetCurrentUser();
        //    List<string> counties = requestDAO.GetCounties(user.Id);
        //    foreach (string s in counties)
        //    {
        //        model.AddCounty(s);
        //    }
        //    return model;
        //}
    }
}