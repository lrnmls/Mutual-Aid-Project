using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.DTO
{
    public class UserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string County { get; set; }
        public bool isAdmin { get; set; } = false;
        public ICollection<Request> Requests { get; set; }
        public ICollection<AcceptedRequest> AcceptedRequests { get; set; }
    }
}
