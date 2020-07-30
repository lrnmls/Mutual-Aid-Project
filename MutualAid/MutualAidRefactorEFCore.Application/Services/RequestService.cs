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
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository requestRepository;
        private readonly IMapper mapper;

        public RequestService(IRequestRepository requestRepository, IMapper mapper)
        {
            this.requestRepository = requestRepository;
            this.mapper = mapper;
        }

        public async Task<bool> AddRequestAsync(RequestDto request)
        {
            var requestEntity = mapper.Map<Request>(request);
            var requestResult = await requestRepository.AddAsync(requestEntity);

            if (!requestResult)
            {
                return false;
            }
            return requestResult;
        }

        public async Task<RequestDto> GetRequestByIdAsync(int requestId)
        {
            var request = await requestRepository.GetByIdAsync(requestId);
            return mapper.Map<RequestDto>(request);
        }

        public async Task<IEnumerable<RequestDto>> GetAllRequestsByUserIdAsync(int userId)
        {
            var requests = await requestRepository.GetAllRequestByUserIdAsync(userId);
            return mapper.Map<IEnumerable<RequestDto>>(requests);
        }

        public async Task<IEnumerable<RequestDto>> GetAllRequestsAsync()
        {
            var requests = await requestRepository.GetAllAsync();
            return mapper.Map<IEnumerable<RequestDto>>(requests);
        }

        public async Task<bool> UpdateRequestAsync(RequestDto request)
        {
            var requestEntity = mapper.Map<Request>(request);
            var requestResult = await requestRepository.UpdateAsync(requestEntity);

            if (!requestResult)
            {
                return false;
            }
            return requestResult;
        }

        public async Task<bool> DeleteRequestAsync(RequestDto request)
        {
            var requestEntity = mapper.Map<Request>(request);
            var requestResult = await requestRepository.DeleteAsync(requestEntity);

            if (!requestResult)
            {
                return false;
            }
            return requestResult;
        }
    }
}
