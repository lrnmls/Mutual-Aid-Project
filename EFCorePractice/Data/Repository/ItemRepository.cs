using EFCorePractice.Data.Context;
using EFCorePractice.Data.Entities;
using EFCorePractice.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Data.Repository
{
    public class ItemRepository : BaseEntityRepository<Item>, IItemRepository
    {
        public ItemRepository(PracticeContext dbContext) : base(dbContext)
        {
        }

        public async Task<IReadOnlyList<Item>> GetAllItemsByOrderIdAsync(int orderId)
        {
            return (IReadOnlyList<Item>)await DbContext.Set<Item>()
                .Include(x => x.Id)
                .Include(x => x.Price)
                .Include(x => x.Description)
                .Include(x => x.Quantity)
                .FirstOrDefaultAsync(x => x.OrderId == orderId);
        }
    }
}
