using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IImageService: IEntityService<Image>
    {
        Image GetById(int Id);
        Task<Image> GetByIdAsync(int Id);
        Task<List<Image>> GetByPatientIdAsync(int PatientId);
        Task<List<Image>> GetByPathologyIdAsync(int PathologyId);
        Task<List<Image>> GetByRadiologyIdAsync(int RadiologyId);
        Task<List<Image>> GetByRadiotherapyIdAsync(int RadiotherapyId);
       
    }
}
