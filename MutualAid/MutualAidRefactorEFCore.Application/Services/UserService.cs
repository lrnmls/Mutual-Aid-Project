using AutoMapper;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Application.Services
{
    public class UserService : IUserService
    {
        protected readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public UserDto GetUserByEmailAsync(string email)
        {
            var user = userRepository.GetUserByEmailAsync(email);
            return mapper.Map<UserDto>(user);
        }

        public async Task<UserDto> GetUserByIdAsync(int userId)
        {
            var user = await userRepository.GetByIdAsync(userId);
            return mapper.Map<UserDto>(user);
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var users = await userRepository.GetAllAsync();
            return mapper.Map<IEnumerable<UserDto>>(users);
        }

        public async Task<bool> AddUserAsync(UserDto user)
        {
            var userEntity = mapper.Map<User>(user);
            var userResult = await userRepository.AddAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<bool> UpdateUserAsync(UserDto user)
        {
            var userEntity = mapper.Map<User>(user);
            var userResult = await userRepository.UpdateAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<bool> DeleteUserAsync(UserDto user)
        {
            var userEntity = mapper.Map<User>(user);
            var userResult = await userRepository.DeleteAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }
    }
}
