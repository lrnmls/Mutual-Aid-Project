using AutoMapper;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Services
{
    public class RequestViewService : IRequestViewService
    {
        private readonly IRequestService requestService;
        private readonly IMapper mapper;

        public RequestViewService(IRequestService requestService, IMapper mapper)
        {
            this.requestService = requestService;
            this.mapper = mapper;
        }

        public async Task<RequestViewModel> GetRequestByIdAsync(int requestId)
        {
            var request = await requestService.GetRequestByIdAsync(requestId);
            return mapper.Map<RequestViewModel>(request);
        }

        public async Task<IEnumerable<RequestViewModel>> GetAllRequestsByUserIdAsync(int userId)
        {
            var requests = await requestService.GetAllRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<RequestViewModel>>(requests);
        }

        public async Task<IEnumerable<RequestViewModel>> GetAllRequestsAsync()
        {
            var requests = await requestService.GetAllRequestsAsync();
            return mapper.Map<IEnumerable<RequestViewModel>>(requests);
        }

        public async Task<bool> AddRequestAsync(RequestViewModel request)
        {
            var requestEntity = mapper.Map<RequestDto>(request);
            var requestResult = await requestService.AddRequestAsync(requestEntity);

            if (!requestResult)
            {
                return false;
            }
            return requestResult;
        }

        public async Task<bool> UpdateRequestAsync(RequestViewModel request)
        {
            var requestEntity = mapper.Map<RequestDto>(request);
            var requestResult = await requestService.UpdateRequestAsync(requestEntity);

            if (!requestResult)
            {
                return false;
            }
            return requestResult;
        }

        public async Task<bool> DeleteRequestAsync(RequestViewModel request)
        {
            var requestEntity = mapper.Map<RequestDto>(request);
            var requestResult = await requestService.DeleteRequestAsync(requestEntity);

            if (!requestResult)
            {
                return false;
            }
            return requestResult;
        }
    }
}
