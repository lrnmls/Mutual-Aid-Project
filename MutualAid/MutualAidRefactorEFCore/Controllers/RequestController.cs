using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Models;

namespace MutualAidRefactorEFCore.UI.Controllers
{
    public class RequestController : Controller
    {
        private readonly IRequestViewService requestViewService;
        private readonly IAuthProvider auth;

        public RequestController(IRequestViewService requestViewService, IAuthProvider auth)
        {
            this.requestViewService = requestViewService;
            this.auth = auth;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RequestDetails(int id)
        {
            return View();
        }

        public async Task<IActionResult> ViewAllRequests()
        {
            var requests = await requestViewService.GetAllRequestsAsync();
            foreach(RequestViewModel req in requests)
            {
                IsAccepted(req.IsAccepted);
            }
            return View(requests);
        }

        public ActionResult CreateRequest()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateRequest(RequestViewModel model)
        {
            var result = await requestViewService.AddRequestAsync(model);

            if (result)
            {
                return RedirectToAction("Index", "User");
            }
            return View();
        }

        public ActionResult EditRequest(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditRequest(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DeleteRequest(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteRequest(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private string IsAccepted(bool isAccepted)
        {
            if (isAccepted)
            {
                return "Yes";
            }
            return "No";
        }
    }
}
