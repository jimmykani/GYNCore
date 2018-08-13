using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface ILateToxicitiesFollowUpService : IEntityService<LateToxicitiesFollowUp>
    {
        LateToxicitiesFollowUp GetById(int Id);
        Task<LateToxicitiesFollowUp> GetByIdAsync(int Id);
        Task<List<LateToxicitiesFollowUp>> GetByPatientIdAsync(int PatientId);
    }
}
