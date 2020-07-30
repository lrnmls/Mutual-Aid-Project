using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Framework.Entities
{
    public interface IBaseAuditableEntity : IEntity
    {
        string CreatedBy { get; set; }
        string UpdatedBy { get; set; }
        DateTime CreateDateTime { get; set; }
        DateTime? UpdateDateTime { get; set; }
    }
}
