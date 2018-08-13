using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface ISiteService : IEntityService<Site>
    {
        Site GetById(int Id);
        Task<Site> GetByIdAsync(int Id);
    }
}
