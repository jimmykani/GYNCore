using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IPatientDetailService : IEntityService<PatientDetail>
    {
        PatientDetail GetById(int Id);
        Task<PatientDetail> GetByIdAsync(int Id);
    }
}
