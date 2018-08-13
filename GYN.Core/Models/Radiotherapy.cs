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
  //  class Radiotherapy
    public partial class Radiotherapy : AuditableEntity<int>

    {
        public bool ChemoUsed { get; set; }
        public bool ExternalBeamRTUsed { get; set; }
        public bool BrachytherapyUsed { get; set; }
        public double? NoOfExtBeamFractions { get; set; }
        public double? NoOfBrachytherapyFractions { get; set; }
        public DateTime? RTCommencedDate { get; set; }
        public DateTime? BTRTCeasedDate { get; set; }
        public bool EBRTBoostNode { get; set; }
        public double? DoseLeftPelvic { get; set; }
        public double? DoseRightPelvic { get; set; }
        public double? DoseLeftCommonIliac { get; set; }
        public double? DoseRightCommonIliac { get; set; }
        public double? DoseLeftAboveL4 { get; set; }
        public double? DoseRightAboveL4 { get; set; }
        [MaxLength(50)]
        public string DoseOther { get; set; }
        public double? TotBED3ToPointA { get; set; }
        public double? TotBED10ToPointA { get; set; }
        public double? TotDoseToBladder { get; set; }
        public double? TotDoseToRectum { get; set; }
        public double? TotBED3ForVolume { get; set; }
        public double? TotBED10ForTumour { get; set; }
        public double? D2ccRectum { get; set; }
        public double? D2ccBladder { get; set; }
        public double? MaxVaginaSurDose { get; set; }
        public string Comment { get; set; }


        public Nullable<int> TimingOfRTId { get; set; }
        public Nullable<int> RTIntentId { get; set; }
        public Nullable<int> DoseRateId { get; set; }
        public Nullable<int> TechniqueId { get; set; }
        public Nullable<int> ApplicatorsId { get; set; }
        public int PatientId { get; set; }
        public int? OldPatientId { get; set; }
        public int? RadiotherapytId { get; set; }

        [ForeignKey("TimingOfRTId")]
        public virtual ReferenceItem TimingOfRT { get; set; }
        [ForeignKey("RTIntentId")]
        public virtual ReferenceItem RTIntent { get; set; }
        [ForeignKey("DoseRateId")]
        public virtual ReferenceItem DoseRate { get; set; }
        [ForeignKey("TechniqueId")]
        public virtual ReferenceItem Technique { get; set; }
        [ForeignKey("ApplicatorsId")]
        public virtual ReferenceItem Applicators { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
    }
}
