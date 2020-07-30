using AutoMapper;
using EFCorePractice.Application.Interfaces;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.UI.Interfaces;
using EFCorePractice.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Services
{
    public class UserViewService : BaseViewService, IUserViewService
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserViewService(IUserService userService, IMapper mapper) : base(mapper, userService)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        public async Task<bool> AddUserAsync(UserViewModel model)
        {
            var userEntity = mapper.Map<UserDTO>(model);
            var userResult = await userService.AddUserAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsersAsync()
        {
            var users = await userService.GetAllUsersAsync();
            return mapper.Map<IEnumerable<UserViewModel>>(users);
        }

        public async Task<UserViewModel> GetUserByIdAsync(int userId)
        {
            var user = await userService.GetUserById(userId);
            return mapper.Map<UserViewModel>(user);
        }
    }
}
