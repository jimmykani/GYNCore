using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GYN.Core.Models
{
    public partial class ClinicalExam : AuditableEntity<int>
    {

        public DateTime ExamDate { get; set; }
        public double? TumorDiameter { get; set; }
        public int? NoOfEnlargedRILN { get; set; }
        public double? LargestLN { get; set; }
        public int? NoOfEnlargedLILN { get; set; }


        public int? CervixId { get; set; }
        public int? RPInvolvementId { get; set; }
        public int? LPInvolvementId { get; set; }
        public int? VaginalInvolvementId { get; set; }
        public int? VulvalInvolvementId { get; set; }
        public int? BladderRectumId { get; set; }
        public int? RightInguinalLNId { get; set; }
        public int? LeftInguinalLNId { get; set; }
        public int? SupraclavicularLNId { get; set; }
        public int PatientId { get; set; }
        public int? OldPatientId { get; set; }


        [ForeignKey("LeftInguinalLNId")]
        public virtual ReferenceItem LeftInguinalLN { get; set; }
        [ForeignKey("SupraclavicularLNId")]
        public virtual ReferenceItem SupraclavicularLN { get; set; }
        [ForeignKey("CervixId")]
        public virtual ReferenceItem Cervix { get; set; }
        [ForeignKey("RPInvolvementId")]
        public virtual ReferenceItem RPInvolvement { get; set; }
        [ForeignKey("LPInvolvementId")]
        public virtual ReferenceItem LPInvolvement { get; set; }
        [ForeignKey("VaginalInvolvementId")]
        public virtual ReferenceItem VaginalInvolvement { get; set; }
        [ForeignKey("VulvalInvolvementId")]
        public virtual ReferenceItem VulvalInvolvement { get; set; }
        [ForeignKey("BladderRectumId")]
        public virtual ReferenceItem BladderRectum { get; set; }
        [ForeignKey("RightInguinalLNId")]
        public virtual ReferenceItem RightInguinalLN { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

    
    }
}
