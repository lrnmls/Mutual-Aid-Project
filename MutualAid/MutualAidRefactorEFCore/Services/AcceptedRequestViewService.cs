using AutoMapper;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.UI.Interfaces;
using MutualAidRefactorEFCore.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Services
{
    public class AcceptedRequestViewService : IAcceptedRequestViewService
    {
        private readonly IAcceptedRequestService acceptedRequestService;
        private readonly IMapper mapper;

        public AcceptedRequestViewService(IAcceptedRequestService acceptedRequestService, IMapper mapper)
        {
            this.acceptedRequestService = acceptedRequestService;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<AcceptedRequestViewModel>> GetAllAcceptedRequestsByUserIdAsync(int userId)
        {
            var acceptedRequests = await acceptedRequestService.GetAllAcceptedRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<AcceptedRequestViewModel>>(acceptedRequests);
        }

        public async Task<IEnumerable<AcceptedRequestViewModel>> GetAllRequestsAsync()
        {
            var acceptedRequests = await acceptedRequestService.GetAllRequestsAsync();
            return mapper.Map<IEnumerable<AcceptedRequestViewModel>>(acceptedRequests);
        }

        public async Task<AcceptedRequestViewModel> GetRequestByIdAsync(int requestId)
        {
            var acceptedRequest = await acceptedRequestService.GetRequestByIdAsync(requestId);
            return mapper.Map<AcceptedRequestViewModel>(acceptedRequest);
        }
    }
}
