using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IReferenceItemService : IEntityService<ReferenceItem>
    {
        ReferenceItem GetById(int Id);
        Task<ReferenceItem> GetByIdAsync(int Id);
        Task<List<ReferenceItem>> GetByHeadIdAsync(int Id);
        IEnumerable<ReferenceItem> GetByHeadId(int Id);

    }
}
