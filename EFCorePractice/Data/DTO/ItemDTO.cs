using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.DTO
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
