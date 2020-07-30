using MutualAidRefactorEFCore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAidRefactorEFCore.Data.DTO
{
    public class AcceptedRequestDto
    {
        public DateTime Date { get; set; }

        //foreign keys
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
