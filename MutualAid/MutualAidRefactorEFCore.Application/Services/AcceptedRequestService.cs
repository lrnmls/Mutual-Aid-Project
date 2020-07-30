using AutoMapper;
using MutualAidRefactorEFCore.Application.Interfaces;
using MutualAidRefactorEFCore.Data.DTO;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Application.Services
{
    public class AcceptedRequestService : IAcceptedRequestService
    {
        private readonly IAcceptedRequestRepository acceptedRequestRepository;
        private readonly IMapper mapper;

        public AcceptedRequestService(IAcceptedRequestRepository acceptedRequestRepository, IMapper mapper)
        {
            this.acceptedRequestRepository = acceptedRequestRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<AcceptedRequestDto>> GetAllAcceptedRequestsByUserIdAsync(int userId)
        {
            var acceptedRequests = await acceptedRequestRepository.GetAllAcceptedRequestsByUserIdAsync(userId);
            return mapper.Map<IEnumerable<AcceptedRequestDto>> (acceptedRequests);
        }

        public async Task<AcceptedRequestDto> GetRequestByIdAsync(int requestId)
        {
            var acceptedRequest = await acceptedRequestRepository.GetByIdAsync(requestId);
            return mapper.Map<AcceptedRequestDto>(acceptedRequest);
        }

        public async Task<IEnumerable<AcceptedRequestDto>> GetAllRequestsAsync()
        {
            var acceptedRequests = await acceptedRequestRepository.GetAllAsync();
            return mapper.Map<IEnumerable<AcceptedRequestDto>>(acceptedRequests);
        }
    }
}
