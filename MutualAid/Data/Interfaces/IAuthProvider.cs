using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Interfaces
{
    public interface IAuthProvider
    {
        //bool IsLoggedIn { get; }
        //Task<User> GetCurrentUser();
        //Task<bool> SignIn(string username, string password);
        //void LogOff();
        //Task<bool> ChangePassword(string existingPassword, string newPassword);
        Task<bool> Register(string email, string password, string firstName, string lastName, string phoneNumber, string county);
    }
}
