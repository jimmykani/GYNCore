using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IPatientService : IEntityService<Patient>
    {
        Patient GetById(int Id);
        Task<Patient> GetByIdAsync(int Id);
        Task<Patient> GetByPatientUrNoAsync(string Urn);
        Task<List<Patient>> GetByPatientLastNameNoAsync(string LastName);
        void MergerPatient(int Oldpatientid, int NewPatientId, Patient entity);
    }
}
