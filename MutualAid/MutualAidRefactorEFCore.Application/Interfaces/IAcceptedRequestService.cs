using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Application.Interfaces
{
    public interface IAcceptedRequestService
    {
        //get
        Task<AcceptedRequestDto> GetRequestByIdAsync(int requestId);
        Task<IEnumerable<AcceptedRequestDto>> GetAllAcceptedRequestsByUserIdAsync(int userId);
        Task<IEnumerable<AcceptedRequestDto>> GetAllRequestsAsync();
    }
}
