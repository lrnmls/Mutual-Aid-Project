using AutoMapper;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Services
{
    public class UserViewService : IUserViewService
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserViewService(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        public async Task<UserViewModel> GetUserByIdAsync(int userId)
        {
            var user = await userService.GetUserByIdAsync(userId);
            return mapper.Map<UserViewModel>(user);
        }

        public UserViewModel GetUserByEmailAsync(string email)
        {
            var user = userService.GetUserByEmailAsync(email);
            return mapper.Map<UserViewModel>(user);
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
        {
            var users = await userService.GetAllUsersAsync();
            return mapper.Map<IEnumerable<UserViewModel>>(users);
        }

        public async Task<bool> AddUserAsync(UserViewModel user)
        {
            var userEntity = mapper.Map<UserDto>(user);
            var userResult = await userService.AddUserAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<bool> UpdateUserAsync(UserViewModel user)
        {
            var userEntity = mapper.Map<UserDto>(user);
            var userResult = await userService.UpdateUserAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<bool> DeleteUserAsync(UserViewModel user)
        {
            var userEntity = mapper.Map<UserDto>(user);
            var userResult = await userService.DeleteUserAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }
    }
}
