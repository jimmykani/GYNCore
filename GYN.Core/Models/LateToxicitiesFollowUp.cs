using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
  //  class LateToxicitiesFollowUp
     public partial class LateToxicitiesFollowUp : AuditableEntity<int>

    {

        public DateTime FollowUpDate { get; set; }
        public int? Bladder { get; set; }
        public int? SmallLargeBowel { get; set; }
        public int? Vagina { get; set; }
        public int? SkinPerineum { get; set; }
        public int? Lymphedema { get; set; }
        public int? Symptoms { get; set; }
        public DateTime? RelapseDocumented { get; set; }
        [MaxLength(500)]
        public string Note { get; set; }

        public int?DiseaseStatusId { get; set; }

        public int?RelapseAtPrimaryId { get; set; }

        public int?TumorLnguineNodeId { get; set; }
        public int?PelvicRelapseId { get; set; }
        public int?AbdomnRelapseId { get; set; }
        public int?SupraclvrRelapseId { get; set; }
        public int?DistantRelapseId { get; set; }
        public int?RelapseTreatedId { get; set; }
        public int?ContactStatusId { get; set; }
        public int?CauseOfDeathId { get; set; }
        public int PatientId { get; set; }
        public int? OldPatientId { get; set; }

        [ForeignKey("DiseaseStatusId")]
        public virtual ReferenceItem DiseaseStatus { get; set; }
        [ForeignKey("RelapseAtPrimaryId")]
        public virtual ReferenceItem RelapseAtPrimary { get; set; }
        [ForeignKey("RelapseTreatedId")]
        public virtual ReferenceItem RelapseTreated { get; set; }
        [ForeignKey("ContactStatusId")]
        public virtual ReferenceItem ContactStatus { get; set; }
        [ForeignKey("CauseOfDeathId")]
        public virtual ReferenceItem CauseOfDeath { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }



        [ForeignKey("TumorLnguineNodeId")]
        public virtual ReferenceItem TumorLnguineNode { get; set; }
        [ForeignKey("PelvicRelapseId")]
        public virtual ReferenceItem PelvicRelapse { get; set; }
        [ForeignKey("AbdomnRelapseId")]
        public virtual ReferenceItem AbdomnRelapse { get; set; }
        [ForeignKey("SupraclvrRelapseId")]
        public virtual ReferenceItem SupraclvrRelapse { get; set; }
        [ForeignKey("DistantRelapseId")]
        public virtual ReferenceItem DistantRelapse { get; set; }
       
    }
}
