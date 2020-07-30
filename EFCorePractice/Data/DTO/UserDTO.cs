using EFCorePractice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Data.DTO
{
    [Serializable]
    public class UserDTO
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
}
