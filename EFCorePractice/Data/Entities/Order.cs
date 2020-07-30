using EFCorePractice.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCorePractice.Data.Entities
{
    public class Order : BaseAuditableEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<Item> Items { get; set; }
        public DateTime DateTime { get; set; }
    }
}
