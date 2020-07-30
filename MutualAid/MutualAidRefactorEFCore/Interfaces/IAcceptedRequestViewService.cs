using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Interfaces
{
    public interface IAcceptedRequestViewService
    {
        //get
        Task<AcceptedRequestViewModel> GetRequestByIdAsync(int requestId);
        Task<IEnumerable<AcceptedRequestViewModel>> GetAllAcceptedRequestsByUserIdAsync(int userId);
        Task<IEnumerable<AcceptedRequestViewModel>> GetAllRequestsAsync();
    }
}
