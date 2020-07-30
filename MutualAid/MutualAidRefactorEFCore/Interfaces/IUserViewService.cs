using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Interfaces
{
    public interface IUserViewService
    {
        //get
        Task<UserViewModel> GetUserByIdAsync(int userId);
        UserViewModel GetUserByEmailAsync(string email);
        Task<IEnumerable<UserViewModel>> GetAllUsersAsync();

        //post
        Task<bool> AddUserAsync(UserViewModel user);
        Task<bool> UpdateUserAsync(UserViewModel user);
        Task<bool> DeleteUserAsync(UserViewModel user);
    }
}
