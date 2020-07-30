using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Application.Interfaces
{
    public interface IUserService : IBaseService
    {
        Task<bool> AddUserAsync(UserDTO user);
        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
        Task<UserDTO> GetUserById(int userId);
    }
}
