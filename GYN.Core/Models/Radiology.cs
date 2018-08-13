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
    // class Radiology
    public partial class Radiology : AuditableEntity<int>
    {

        public DateTime ExamDate { get; set; }
        public double? TransTumorDiameter { get; set; }
        public double? LogitTumorDiameter { get; set; }
        public double? APTumorDiameter { get; set; }
        public int? AenPelvicMass { get; set; }
        public int? SUVMaxPrimary { get; set; }
        public int? SUVMaxLymphNode { get; set; }
        [MaxLength(255)]
        public string SiteofHottNode { get; set; }
        [MaxLength(255)]
        public string SiteofLargetNode { get; set; }
        [MaxLength(255)]
        public string SiteofECENode { get; set; }
        [MaxLength(255)]
        public string DWIEquivocalNodes { get; set; }
        [MaxLength(255)]
        public string Insufficiencyfracture { get; set; }
        public int? LymphNodeEnlarged { get; set; }

        public int? PurposeId { get; set; }
        public int? InvestigationId { get; set; }
        public int? EpicentMassId { get; set; }
        public int? UterineBodyId { get; set; }
        public int? MyometrialInvId { get; set; }
        public int? CervixId { get; set; }
        public int? ReportedById { get; set; }
        public int? VaginaId { get; set; }
        public int? BladderId { get; set; }
        public int? RectunId { get; set; }
        public int? RightParametriumId { get; set; }
        public int? LeftParametriumId { get; set; }
        public int? UretericObstId { get; set; }
        public int? DistantMetastatsesId { get; set; }
        public int? TreatmentRespId { get; set; }
        public int PatientId { get; set; }
        public int? OldPatientId { get; set; }
        public int? RadiologyId { get; set; }

        [ForeignKey("PurposeId")]
        public virtual ReferenceItem Purpose { get; set; }
        [ForeignKey("InvestigationId")]
        public virtual ReferenceItem Investigation { get; set; }
        [ForeignKey("EpicentMassId")]
        public virtual ReferenceItem EpicentMass { get; set; }
        [ForeignKey("UterineBodyId")]
        public virtual ReferenceItem UterineBody { get; set; }
        [ForeignKey("MyometrialInvId")]
        public virtual ReferenceItem MyometrialInv { get; set; }
        [ForeignKey("CervixId")]
        public virtual ReferenceItem Cervix { get; set; }
        [ForeignKey("ReportedById")]
        public virtual ReferenceItem ReportedBy { get; set; }
        [ForeignKey("VaginaId")]
        public virtual ReferenceItem Vagina { get; set; }
        [ForeignKey("BladderId")]
        public virtual ReferenceItem Bladder { get; set; }
        [ForeignKey("RectunId")]
        public virtual ReferenceItem Rectun { get; set; }
        [ForeignKey("RightParametriumId")]
        public virtual ReferenceItem RightParametrium { get; set; }
        [ForeignKey("LeftParametriumId")]
        public virtual ReferenceItem LeftParametrium { get; set; }
        [ForeignKey("UretericObstId")]
        public virtual ReferenceItem UretericObst { get; set; }
        [ForeignKey("DistantMetastatsesId")]
        public virtual ReferenceItem DistantMetastatses { get; set; }
        [ForeignKey("TreatmentRespId")]
        public virtual ReferenceItem TreatmentResp { get; set; }
        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }
        public virtual ICollection<Site> Sites { get; set; }

    }
}
