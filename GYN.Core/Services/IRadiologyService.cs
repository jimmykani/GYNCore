using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IRadiologyService : IEntityService<Radiology>
    {
        Radiology GetById(int Id);
        Task<Radiology> GetByIdAsync(int Id);
        Task<List<Radiology>> GetByPatientIdAsync(int PatientId);
        void Create(Radiology entity, string[] Sites);
        void Update(Radiology entity, string[] Sites);
    }
}
