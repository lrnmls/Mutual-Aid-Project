using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Application.Interfaces
{
    public interface IRequestService
    {
        //get
        Task<RequestDto> GetRequestByIdAsync(int requestId);
        Task<IEnumerable<RequestDto>> GetAllRequestsByUserIdAsync(int userId);
        Task<IEnumerable<RequestDto>> GetAllRequestsAsync();

        //post
        Task<bool> AddRequestAsync(RequestDto request);
        Task<bool> UpdateRequestAsync(RequestDto request);
        Task<bool> DeleteRequestAsync(RequestDto request);
    }
}
