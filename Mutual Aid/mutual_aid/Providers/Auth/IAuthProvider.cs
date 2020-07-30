using mutual_aid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mutual_aid.Providers.Auth
{
    public interface IAuthProvider
    {
        bool IsLoggedIn { get; }
        User GetCurrentUser();
        bool SignIn(string username, string password);
        void LogOff();
        bool ChangeOwnPassword(string existingPassword, string newPassword);
        bool ChangeUserPassword(User user, string existingPassword, string newPassword);
        void Register(string email, string password, string role, string firstName, string lastName, string phoneNumber, string county);
        bool UserHasRole(string[] roles);
    }
}
