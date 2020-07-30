using EFCorePractice.Framework.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCorePractice.Data.Entities
{
    public class User : BaseAuditableEntity
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public List<Order> Orders { get; set; }
    }
}
