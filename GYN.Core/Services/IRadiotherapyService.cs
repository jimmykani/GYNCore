using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IRadiotherapyService : IEntityService<Radiotherapy>
    {
        Radiotherapy GetById(int Id);
        Task<Radiotherapy> GetByIdAsync(int Id);
        Task<List<Radiotherapy>> GetByPatientIdAsync(int PatientId);
    }
}
