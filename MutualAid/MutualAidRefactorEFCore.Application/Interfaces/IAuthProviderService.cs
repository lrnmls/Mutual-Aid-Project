using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Application.Interfaces
{
    public interface IAuthProviderService
    {
        Task<bool> Register(string email, string password, string firstName, string lastName, string phoneNumber, string county);
    }
}
