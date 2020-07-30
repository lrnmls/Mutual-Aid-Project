using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Authentication
{
    public interface IAuthProvider
    {
        bool IsLoggedIn { get; }
        User GetCurrentUser();
        bool SignIn(string username, string password);
        void LogOff();
        bool ChangePassword(string existingPassword, string newPassword);
        void Register(string email, string password, string firstName, string lastName, string phoneNumber, string county);
    }
}
