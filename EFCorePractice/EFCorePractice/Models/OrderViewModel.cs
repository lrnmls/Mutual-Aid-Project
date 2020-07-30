using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePractice.UI.Models
{
    public class OrderViewModel : BaseViewModel
    {
        public int UserId { get; set; }
        public UserViewModel User { get; set; }
        public decimal TotalPrice { get; set; }
        public IEnumerable<ItemViewModel> Items { get; set; }
        public DateTime DateTime { get; set; }
    }
}
