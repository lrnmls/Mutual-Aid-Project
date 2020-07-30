using Microsoft.AspNetCore.Http;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Data.Auth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MutualAidRefactorEFCore.Data.DTO;
using AutoMapper;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Application.Interfaces;

namespace MutualAidRefactorEFCore.Application.Services
{
    public class AuthProviderService : IAuthProviderService
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public static string SessionKey = "Auth_User";

        public AuthProviderService(IHttpContextAccessor contextAccessor, IUserRepository userRepository, IMapper mapper)
        {
            this.contextAccessor = contextAccessor;
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Register(string email, string password, string firstName, string lastName, string phoneNumber, string county)
        {
            var hashProvider = new HashProvider();
            var passwordHash = hashProvider.HashPassword(password);

            var userDto = new UserDto
            {
                Email = email,
                Password = passwordHash.Password,
                Salt = passwordHash.Salt,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                County = county
            };
            var userEntity = mapper.Map<User>(userDto);

            var result = await userRepository.AddAsync(userEntity);

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
