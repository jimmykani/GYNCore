using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public partial class Pathology : AuditableEntity<int>//, IValidatableObject
    {
        public Pathology()
        {

           // this.PathologySiteId = new List<PathologySite>();

        }
        public DateTime SurgeryDate { get; set; }
       
        
        public double? TumorDiameter { get; set; }
       
        
        public double? DepthofInvasion { get; set; }
        public double? MyometriumThickness { get; set; }
        public double? CervixThickness { get; set; }
        public int? ResectionMarginId { get; set; }

        public int? GrowthPatternId { get; set; }
        public int? HistologicSubtypeId { get; set; }
        public int? SiteofTumourId { get; set; }
        public int? TumorGradingId { get; set; }
        public int? LVSIId { get; set; }
        public int? SurgerytoLNId { get; set; }
        public int PatientId { get; set; }

        public int? NoOfNodesRemoved { get; set; }
        [MaxLength(1)]
        public string NodesPositive { get; set; }
        public int? NoOfNodesPositive { get; set; }
        [MaxLength(1)]
        public string ECE { get; set; }
        public double? LrgPositiveNodeSize { get; set; }
        public int? OldPatientId { get; set; }
        public int? PathologyId { get; set; }

        [ForeignKey("SurgerytoLNId")]
        public virtual ReferenceItem SurgerytoLN { get; set; }
        [ForeignKey("LVSIId")]
        public virtual ReferenceItem LVSI { get; set; }
        [ForeignKey("GrowthPatternId")]
        public virtual ReferenceItem GrowthPattern { get; set; }
        [ForeignKey("ResectionMarginId")]
        public virtual ReferenceItem ResectionMargin { get; set; }
        [ForeignKey("TumorGradingId")]
        public virtual ReferenceItem TumorGrading { get; set; }
        [ForeignKey("HistologicSubtypeId")]
        public virtual ReferenceItem HistologicSubtype { get; set; }
        [ForeignKey("SiteofTumourId")]
        public virtual ReferenceItem SiteofTumour { get; set; }//

        [ForeignKey("PatientId")]
        public virtual Patient Patient { get; set; }

        public virtual ICollection<Site> Sites { get; set; }

        
    }
}