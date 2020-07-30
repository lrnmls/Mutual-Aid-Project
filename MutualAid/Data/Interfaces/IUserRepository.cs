using MutualAidRefactorEFCore.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        Task<User> GetUserByEmailAsync(string email);
    }
}
