﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MutualAidRefactorEFCore.UI.Models
{
    public class UserViewModel : BaseViewModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("County")]
        public string County { get; set; }

        [DisplayName("Role")]
        public bool isAdmin { get; set; } = false;

        public ICollection<RequestViewModel> Requests { get; set; }
        public ICollection<AcceptedRequestViewModel> AcceptedRequests { get; set; }
    }
}
