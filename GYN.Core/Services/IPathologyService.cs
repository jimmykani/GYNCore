using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IPathologyService : IEntityService<Pathology>
    {
        Pathology GetById(int Id);
        Task<Pathology> GetByIdAsync(int Id);
        Task<List<Pathology>> GetByPatientIdAsync(int PatientId);
        void Create(Pathology entity,string[] Sites);
        void Update(Pathology entity, string[] Sites);
    }
}
