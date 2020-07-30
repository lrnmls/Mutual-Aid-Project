using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Framework.Entities
{
    public abstract class BaseAuditableEntity : BaseEntity, IBaseAuditableEntity
    {
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
