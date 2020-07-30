using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Interfaces
{
    public interface IAcceptedRequestRepository : IBaseRepository<AcceptedRequest>
    {
        Task<IReadOnlyList<AcceptedRequest>> GetAllAcceptedRequestsByUserIdAsync(int userId);
    }
}
