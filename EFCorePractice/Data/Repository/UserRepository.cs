using EFCorePractice.Data.Context;
using EFCorePractice.Data.DTO;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Data.Repository
{
    public class UserRepository : BaseEntityRepository<User>, IUserRepository
    {
        public UserRepository(PracticeContext dbContext) : base(dbContext)
        {
        }
    }
}
