using EFCorePractice.Application.Interfaces;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace EFCorePractice.Application.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AddUserAsync(UserDTO user)
        {
            var userEntity = mapper.Map<User>(user);
            var userResult = await userRepository.AddAsync(userEntity);

            if (!userResult)
            {
                return false;
            }
            return userResult;
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsersAsync()
        {
            var users = await userRepository.GetAllAsync();
            return mapper.Map<IEnumerable<UserDTO>>(users);
        }

        public async Task<UserDTO> GetUserById(int userId)
        {
            var user = await userRepository.GetByIdAsync(userId);
            var userDTO = mapper.Map<UserDTO>(user);
            return userDTO;
        }
    }
}
