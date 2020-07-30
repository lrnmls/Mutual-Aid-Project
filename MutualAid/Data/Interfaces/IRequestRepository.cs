using MutualAidRefactorEFCore.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Interfaces
{
    public interface IRequestRepository : IBaseRepository<Request>
    {
        Task<IReadOnlyList<Request>> GetAllRequestByUserIdAsync(int userId);
    }
}
