using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IReferenceHeaderService : IEntityService<ReferenceHeader>
    {
        ReferenceHeader GetById(int Id);
        Task<ReferenceHeader> GetByIdAsync(int Id);

    }
}
