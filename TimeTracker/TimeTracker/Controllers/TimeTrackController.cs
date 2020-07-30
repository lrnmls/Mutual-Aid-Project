using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TimeTracker.Controllers
{
    public class TimeTrackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
