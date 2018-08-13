using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces.Services
{
    public interface IReferenceService : IEntityService<ReferenceItem>
    {
        ReferenceItem GetById(int Id);
        Task<ReferenceItem> GetByIdAsync(int Id);
        Task<List<ReferenceItem>> GetDiagnosisAsync();
        Task<List<ReferenceItem>> GetReasonForPresentationAsync();
        Task<List<ReferenceItem>> GetSmokingStatusAsync();
        Task<List<ReferenceItem>> GetCervixAsync();
        Task<List<ReferenceItem>> GetRightParametrialInvolvementAsync();
        Task<List<ReferenceItem>> GetLeftParametrialInvolvementAsync();
        Task<List<ReferenceItem>> GetVaginalInvolvementAsync();
        Task<List<ReferenceItem>> GetVulvalInvolvementAsync();
        Task<List<ReferenceItem>> GetBladderAndRectumAsync();
        Task<List<ReferenceItem>> GetRightInguinalLNAsync();
        Task<List<ReferenceItem>> GetLeftInguinalLNAsync();
        Task<List<ReferenceItem>> GetSupraclavicularLNAsync();
        Task<List<ReferenceItem>> GetSiteOfTumourAsync();
        Task<List<ReferenceItem>> GetHistologicSubtypeAsync();
        Task<List<ReferenceItem>> GetTumorGradingAsync();
        Task<List<ReferenceItem>> GetResectionMarginAsync();
        Task<List<ReferenceItem>> GetGrowthPatternAsync();
        Task<List<ReferenceItem>> GetLVSIAsync();
        Task<List<ReferenceItem>> GetSurgeryToLNAsync();
        Task<List<ReferenceItem>> GetPurposeAsync();
        Task<List<ReferenceItem>> GetInvestigationAsync();
        Task<List<ReferenceItem>> GetEpicenterOfMassAsync();
        Task<List<ReferenceItem>> GetUterineBodyAsync();
        Task<List<ReferenceItem>> GetMyometrialInvasionAsync();
        Task<List<ReferenceItem>> GetCervixRDAsync();
        Task<List<ReferenceItem>> GetVaginaAsync();
        Task<List<ReferenceItem>> GetBladderAsync();
        Task<List<ReferenceItem>> GetRectumAsync();
        Task<List<ReferenceItem>> GetLeftParametriumAsync();
        Task<List<ReferenceItem>> GetRightParametriumAsync();
        Task<List<ReferenceItem>> GetUretericObstructionAsync();
        Task<List<ReferenceItem>> GetDistantMetastasesAsync();
        Task<List<ReferenceItem>> GetMRIResponseAsync();
        Task<List<ReferenceItem>> GetTimingOfRTAsync();
        Task<List<ReferenceItem>> GetRTIntentAsync();
        Task<List<ReferenceItem>> GetTechniqueAsync();
        Task<List<ReferenceItem>> GetDoseRateAsync();
        Task<List<ReferenceItem>> GetTypeOfApplicatorAsync();
        Task<List<ReferenceItem>> GetDiseaseStatusAsync();
        Task<List<ReferenceItem>> GetRelapseAtPrimarySiteAsync();
        Task<List<ReferenceItem>> GetRelapsetreatedAsync();
        Task<List<ReferenceItem>> GetStatusAtContactAsync();
        Task<List<ReferenceItem>> GetCauseOfDeathAsync();
        Task<List<ReferenceItem>> GetRefeFowUpHospitalAsync();

    }
}
