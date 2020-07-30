using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Models;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAuthProviderViewService authProviderViewService;
        private readonly IMapper mapper;

        public AccountController(IAuthProviderViewService authProviderViewService, IMapper mapper)
        {
            this.authProviderViewService = authProviderViewService;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                authProviderViewService.Register(model.Email, model.Password, model.FirstName, model.LastName, model.PhoneNumber, model.County);
                return RedirectToAction("Login", "Account");
            }
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var validLogin = await authProvider.SignIn(model.Email, model.Password);
        //        var userEntity = authProvider.GetCurrentUser();
        //        var userDto = mapper.Map<UserDto>(userEntity);
        //        var user = mapper.Map<UserViewModel>(userDto);
        //        if (validLogin)
        //        {
        //            if (user.isAdmin)
        //            {
        //                return RedirectToAction("AdminHomePage", "Admin");
        //            }
        //            else
        //            {
        //                return RedirectToAction("Index", "User");
        //            }
        //        }
        //    }
        //    return View(model);
        //}
    }
}
