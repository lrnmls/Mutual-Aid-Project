using Microsoft.AspNetCore.Http;
using MutualAidRefactorEFCore.Data.Context;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Data.Repository.Base;
using System;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Auth
{
    public class SessionAuthProvider : IAuthProvider
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly IUserRepository userRepository;
        public static string SessionKey = "Auth_User";

        public SessionAuthProvider(IHttpContextAccessor contextAccessor, IUserRepository userRepository)
        {
            this.contextAccessor = contextAccessor;
            this.userRepository = userRepository;
        }

        ISession Session => contextAccessor.HttpContext.Session;

        public bool IsLoggedIn => !String.IsNullOrEmpty(Session.GetString(SessionKey));

        public async Task<bool> SignIn(string email, string password)
        {
            var user = await userRepository.GetUserByEmailAsync(email);
            var hashProvider = new HashProvider();

            if (user != null && hashProvider.VerifyPasswordMatch(user.Password, password, user.Salt))
            {
                Session.SetString(SessionKey, user.Email);
                return true;
            }

            return false;
        }

        public void LogOff()
        {
            Session.Clear();
        }

        public async Task<bool> ChangePassword(string existingPassword, string newPassword)
        {
            var hashProvider = new HashProvider();
            var user = await GetCurrentUser();

            // Confirm existing password match
            if (user != null && hashProvider.VerifyPasswordMatch(user.Password, existingPassword, user.Salt))
            {
                // Hash new password
                var newHash = hashProvider.HashPassword(newPassword);
                user.Password = newHash.Password;
                user.Salt = newHash.Salt;

                // Save into the db
                await userRepository.UpdateAsync(user);

                return true;
            }

            return false;
        }

        public async Task<User> GetCurrentUser()
        {
            var username = Session.GetString(SessionKey);

            if (!String.IsNullOrEmpty(username))
            {
                return await userRepository.GetUserByEmailAsync(username);
            }

            return null;
        }

        public async Task<bool> Register(string email, string password, string firstName, string lastName, string phoneNumber, string county)
        {
            var hashProvider = new HashProvider();
            var passwordHash = hashProvider.HashPassword(password);

            var user = new User
            {
                Email = email,
                Password = passwordHash.Password,
                Salt = passwordHash.Salt,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                County = county
            };

            var result = await userRepository.AddAsync(user);

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

