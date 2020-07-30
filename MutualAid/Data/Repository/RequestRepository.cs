using Microsoft.EntityFrameworkCore;
using MutualAidRefactorEFCore.Data.Context;
using MutualAidRefactorEFCore.Data.Entities;
using MutualAidRefactorEFCore.Data.Interfaces;
using MutualAidRefactorEFCore.Data.Repository.Base;
using MutualAidRefactorEFCore.Framework.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.Data.Repository
{
    public class RequestRepository : BaseEntityRepository<Request>, IRequestRepository
    {
        private readonly MutualAidContext context;

        public RequestRepository(MutualAidContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<IReadOnlyList<Request>> GetAllRequestByUserIdAsync(int userId)
        {
            return (IReadOnlyList<Request>)await DbContext.Set<Request>()
                .Include(x => x.Allergens)
                .Include(x => x.Bread)
                .Include(x => x.CannedFood)
                .Include(x => x.Cereal)
                .Include(x => x.Conditioner)
                .Include(x => x.Dairy)
                .Include(x => x.Date)
                .Include(x => x.Disinfectant)
                .Include(x => x.HandSoap)
                .Include(x => x.Id)
                .Include(x => x.IsAccepted)
                .Include(x => x.Meat)
                .Include(x => x.Pantry)
                .Include(x => x.PaperTowels)
                .Include(x => x.Produce)
                .Include(x => x.Seafood)
                .Include(x => x.Shampoo)
                .Include(x => x.ToiletPaper)
                .Include(x => x.Toothpaste)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
