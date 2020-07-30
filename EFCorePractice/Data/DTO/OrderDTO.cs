using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.DTO
{
    [Serializable]
    public class OrderDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public DateTime DateTime { get; set; }
    }
}
