using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Interfaces
{
    public interface IAuthProviderViewService
    {
        Task<bool> Register(string email, string password, string firstName, string lastName, string phoneNumber, string county);
    }
}
