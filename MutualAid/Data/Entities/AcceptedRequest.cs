using System;
using MutualAidRefactorEFCore.Framework.Entities;

namespace MutualAidRefactorEFCore.Data.Entities
{
    public class AcceptedRequest : BaseEntity
    {
        public DateTime Date { get; set; }

        //foreign keys
        public int RequestId { get; set; }
        public Request Request { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
