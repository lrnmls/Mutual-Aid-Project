using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Interfaces
{
    public interface IUserViewService : IBaseViewService
    {
        Task<bool> AddUserAsync(UserViewModel model);
        Task<IEnumerable<UserViewModel>> GetAllUsersAsync();
        Task<UserViewModel> GetUserByIdAsync(int userId);
    }
}
