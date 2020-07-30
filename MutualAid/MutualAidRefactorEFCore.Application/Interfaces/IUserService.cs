using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Application.Interfaces
{
    public interface IUserService
    {
        //get
        Task<UserDto> GetUserByIdAsync(int userId);
        UserDto GetUserByEmailAsync(string email);
        Task<IEnumerable<UserDto>> GetAllUsersAsync();

        //post
        Task<bool> AddUserAsync(UserDto user);
        Task<bool> UpdateUserAsync(UserDto user);
        Task<bool> DeleteUserAsync(UserDto user);
    }
}
