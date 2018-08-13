using GYN.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public partial class PatientDetail : AuditableEntity<int>//, IValidatableObject
    {
        public DateTime FirstAttendDate { get; set; }
       
        [MaxLength(12)]
        public string OtherURNumber { get; set; }
        [MaxLength(30)]
        public string OtherHospital { get; set; }
        public DateTime HisDiagnosisDate { get; set; }
        [MaxLength(1)]
        public string PIBDDPresent { get; set; }
       
        [MaxLength(10)]
        public string FIGOStaging { get; set; }
        public int? ECOGPerformanceStatus { get; set; }
       
        [MaxLength(500)]
        public string Comments { get; set; }
        public int? PatientId { get; set; }
        public int? OldPatientId { get; set; }

        public int? ReferringHospitalId { get; set; }
        public int? PresentationReasonId { get; set; }
        public int? DiagnosisId { get; set; }
        public int? SmkingStatusId { get; set; }
        //  [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
        [ForeignKey("DiagnosisId")]
        public virtual ReferenceItem Diagnosis { get; set; }
        [ForeignKey("ReferringHospitalId")]
        public virtual ReferenceItem ReferringHospital { get; set; }
        [ForeignKey("PresentationReasonId")]
        public virtual ReferenceItem PresentationReason { get; set; }
        [ForeignKey("SmkingStatusId")]
        public virtual ReferenceItem SmkingStatus { get; set; }
        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    if (ReferringHospital.ReferenceHeader.Id != 0)
        //    {
        //        yield return new ValidationResult
        //     ("Blog Title cannot match Blogger Name", new[] { "ReferringHospital", "ReferringHospital" });
        //    }
        //    if (PresentationReason.ReferenceHeader.Id != 2)
        //    {
        //        yield return new ValidationResult
        //     ("Blog Title cannot match Blogger Name", new[] { "ReferringHospital", "ReferringHospital" });
        //    }
        //    if (Diagnosis.ReferenceHeader.Id != 1)
        //    {
        //        yield return new ValidationResult
        //     ("Blog Title cannot match Blogger Name", new[] { "ReferringHospital", "ReferringHospital" });
        //    }
        //}

    }
}
