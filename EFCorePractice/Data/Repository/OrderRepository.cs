using EFCorePractice.Data.Context;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Data.Repository
{
    public class OrderRepository : BaseEntityRepository<Order>, IOrderRepository
    {
        public OrderRepository(PracticeContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Order>> GetAllOrdersByUserIdAsync(int userId)
        {
            return (IReadOnlyList<Order>)await DbContext.Set<Order>()
                .Include(x => x.Id)
                .Include(x => x.TotalPrice)
                .Include(x => x.DateTime)
                .FirstOrDefaultAsync(x => x.UserId == userId);
        }
    }
}
