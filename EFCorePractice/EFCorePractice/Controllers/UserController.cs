using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCorePractice.UI.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserViewService userViewService;
        private readonly IMapper mapper;

        public UserController(IUserViewService userViewService,  IMapper mapper)
        {
            this.userViewService = userViewService;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserViewModel model)
        {
            var userResult = await userViewService.AddUserAsync(model);
            if (!userResult)
            {
                return View();
            }
            return RedirectToAction("Index", "User");
        }

        public async Task<IActionResult> ViewAllUsers()
        {
            var users = await userViewService.GetAllUsersAsync();
            return View(users);
        }

        public async Task<IActionResult> ViewUserDetails(int userId)
        {
            var user = await userViewService.GetUserByIdAsync(userId);
            return View(user);
        }
    }
}
