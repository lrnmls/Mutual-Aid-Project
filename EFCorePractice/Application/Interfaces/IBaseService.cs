using EFCorePractice.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Application.Interfaces
{
    public interface IBaseService
    {
        Task<IEnumerable<DropdownDTO>> GetDropdownDtosAsync();
    }
}
