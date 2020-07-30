using Microsoft.EntityFrameworkCore;
using MutualAidRefactorEFCore.Data.Context;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Data.Repository.Base;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Repository
{
    public class UserRepository : BaseEntityRepository<User>, IUserRepository
    {
        private readonly MutualAidContext context;

        public UserRepository(MutualAidContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<User> GetUserByEmailAsync(string email)
        {
            var user = await context.FindAsync<User>(email);
            return user;
        }
    }
}
