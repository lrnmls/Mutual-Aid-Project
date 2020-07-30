using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Interfaces
{
    public interface IRequestViewService
    {
        //get
        Task<RequestViewModel> GetRequestByIdAsync(int requestId);
        Task<IEnumerable<RequestViewModel>> GetAllRequestsByUserIdAsync(int userId);
        Task<IEnumerable<RequestViewModel>> GetAllRequestsAsync();

        //post
        Task<bool> AddRequestAsync(RequestViewModel request);
        Task<bool> UpdateRequestAsync(RequestViewModel request);
        Task<bool> DeleteRequestAsync(RequestViewModel request);
    }
}
