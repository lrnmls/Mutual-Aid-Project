using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Data.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
