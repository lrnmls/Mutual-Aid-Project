using Microsoft.AspNetCore.Http;
using mutual_aid.DAL;
using mutual_aid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mutual_aid.Providers.Auth
{
    public class SessionAuthProvider : IAuthProvider
    {
        private readonly IHttpContextAccessor contextAccessor;
        private readonly UserSqlDAO userDAO;
        public static string SessionKey = "Auth_User";

        public SessionAuthProvider(IHttpContextAccessor contextAccessor, UserSqlDAO userDAO)
        {
            this.contextAccessor = contextAccessor;
            this.userDAO = userDAO;
        }

        ISession Session => contextAccessor.HttpContext.Session;

        public bool IsLoggedIn => !String.IsNullOrEmpty(Session.GetString(SessionKey));

        public bool SignIn(string email, string password)
        {
            var user = userDAO.GetUser(email);
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

        public bool ChangePassword(string existingPassword, string newPassword)
        {
            var hashProvider = new HashProvider();
            var user = GetCurrentUser();

            // Confirm existing password match
            if (user != null && hashProvider.VerifyPasswordMatch(user.Password, existingPassword, user.Salt))
            {
                // Hash new password
                var newHash = hashProvider.HashPassword(newPassword);
                user.Password = newHash.Password;
                user.Salt = newHash.Salt;

                // Save into the db
                userDAO.UpdatePassword(user);

                return true;
            }

            return false;
        }

        public bool ChangePasswordOfUser(User user, string existingPassword, string newPassword)
        {
            var hashProvider = new HashProvider();

            // Confirm existing password match
            if (user != null && hashProvider.VerifyPasswordMatch(user.Password, existingPassword, user.Salt))
            {
                // Hash new password
                var newHash = hashProvider.HashPassword(newPassword);
                user.Password = newHash.Password;
                user.Salt = newHash.Salt;

                // Save into the db
                userDAO.UpdatePassword(user);

                return true;
            }

            return false;
        }

        public User GetCurrentUser()
        {
            var email = Session.GetString(SessionKey);

            if (!String.IsNullOrEmpty(email))
            {
                return userDAO.GetUser(email);
            }

            return null;
        }

        public void Register(string email, string password, string role, string firstName, string lastName, string phoneNumber, string county)
        {
            var hashProvider = new HashProvider();
            var passwordHash = hashProvider.HashPassword(password);

            var user = new User
            {
                Email = email,
                Password = passwordHash.Password,
                Role = role,
                Salt = passwordHash.Salt,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                County = county
            };

            userDAO.RegisterUser(user);
            //Session.SetString(SessionKey, user.Email);
        }

        public bool UserHasRole(string[] roles)
        {
            var user = GetCurrentUser();
            return (user != null) &&
                roles.Any(r => r.ToLower() == user.Role.ToLower());
        }
    }
}
