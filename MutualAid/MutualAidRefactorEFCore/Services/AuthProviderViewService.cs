using AutoMapper;
using Microsoft.AspNetCore.Http;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.Data.Auth;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Services
{
    public class AuthProviderViewService : IAuthProviderViewService
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IUserService userService;
        private readonly IMapper mapper;
        public static string SessionKey = "Auth_User";

        public AuthProviderViewService(IHttpContextAccessor contextAccessor, IUserService userService, IMapper mapper)
        {
            this.contextAccessor = contextAccessor;
            this.userService = userService;
            this.mapper = mapper;
        }

        public async Task<bool> Register(string email, string password, string firstName, string lastName, string phoneNumber, string county)
        {
            var hashProvider = new HashProvider();
            var passwordHash = hashProvider.HashPassword(password);

            var userViewModel = new UserViewModel
            {
                Email = email,
                Password = passwordHash.Password,
                Salt = passwordHash.Salt,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                County = county
            };
            var userDto = mapper.Map<UserDto>(userViewModel);

            var result = await userService.AddUserAsync(userDto);

            if (result)
            {
                return true;
            }
            return false;
            //Session.SetString(SessionKey, user.Email);
            //SignIn(user.Email, user.Password);
        }
    }
}
