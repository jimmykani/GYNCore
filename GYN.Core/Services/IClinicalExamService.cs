using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IClinicalExamService : IEntityService<ClinicalExam>
    {
        ClinicalExam GetById(int Id);
        Task<ClinicalExam> GetByIdAsync(int Id);
        Task<List<ClinicalExam>> GetByPatientIdAsync(int PatientId);
    }
}
