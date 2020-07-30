using Microsoft.EntityFrameworkCore;
using MutualAidRefactorEFCore.Data.Context;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Data.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Repository
{
    public class AcceptedRequestRepository : BaseEntityRepository<AcceptedRequest>, IAcceptedRequestRepository
    {
        private readonly MutualAidContext context;

        public AcceptedRequestRepository(MutualAidContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<AcceptedRequest>> GetAllAcceptedRequestsByUserIdAsync(int userId)
        {
            return (IReadOnlyList<AcceptedRequest>)await DbContext.Set<AcceptedRequest>()
                .Include(x => x.Id)
                .Include(x => x.Request)
                .Include(x => x.User)
                .Include(x => x.Date)
                .FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
