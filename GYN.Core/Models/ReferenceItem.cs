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
    public partial class ReferenceItem : Entity<int>
    {
        public ReferenceItem()
        {
            //this.ReferringHospital = new HashSet<PatientDetail>();
            //this.Diagnosis = new HashSet<PatientDetail>();
            //this.PresentationReason = new HashSet<PatientDetail>();

            //this.Cervix = new HashSet<ClinicalExam>();
            //this.RPInvolvement = new HashSet<ClinicalExam>();
            //this.LPInvolvement = new HashSet<ClinicalExam>();
            //this.VaginalInvolvement = new HashSet<ClinicalExam>();
            //this.VulvalInvolvement = new HashSet<ClinicalExam>();
            //this.BladderRectum = new HashSet<ClinicalExam>();
            //this.RightInguinalLN = new HashSet<ClinicalExam>();
            //this.LeftInguinalLN = new HashSet<ClinicalExam>();
            //this.SupraclavicularLN = new HashSet<ClinicalExam>();

            //this.SiteofTumour = new HashSet<Pathology>();
            //this.HistologicSubtype = new HashSet<Pathology>();
            //this.TumorGrading = new HashSet<Pathology>();
            //this.ResectionMargin = new HashSet<Pathology>();
            //this.GrowthPattern = new HashSet<Pathology>();
            //this.LVSI = new HashSet<Pathology>();


        }
        [Index("IX_ItemAndHeader", 1)]
        [MaxLength(20)]
        public string ItemId { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Index("IX_ItemAndHeader", 2)]
        public int ReferenceHeaderId { get; set; }
        [ForeignKey("ReferenceHeaderId")]
        public virtual ReferenceHeader ReferenceHeader { get; set; }

        //public virtual ICollection<PatientDetail> ReferringHospital { get; set; }
        //public virtual ICollection<PatientDetail> Diagnosis { get; set; }
        //public virtual ICollection<PatientDetail> PresentationReason { get; set; }

        //public virtual ICollection<ClinicalExam> Cervix { get; set; }
        //public virtual ICollection<ClinicalExam> RPInvolvement { get; set; }
        //public virtual ICollection<ClinicalExam> LPInvolvement { get; set; }
        //public virtual ICollection<ClinicalExam> VaginalInvolvement { get; set; }
        //public virtual ICollection<ClinicalExam> VulvalInvolvement { get; set; }
        //public virtual ICollection<ClinicalExam> BladderRectum { get; set; }
        //public virtual ICollection<ClinicalExam> RightInguinalLN { get; set; }
        //public virtual ICollection<ClinicalExam> LeftInguinalLN { get; set; }
        //public virtual ICollection<ClinicalExam> SupraclavicularLN { get; set; }

        //public virtual ICollection<Pathology> SiteofTumour { get; set; }
        //public virtual ICollection<Pathology> HistologicSubtype { get; set; }
        //public virtual ICollection<Pathology> TumorGrading { get; set; }
        //public virtual ICollection<Pathology> ResectionMargin { get; set; }
        //public virtual ICollection<Pathology> GrowthPattern { get; set; }
        //public virtual ICollection<Pathology> LVSI { get; set; }
        //public virtual ICollection<Pathology> SurgerytoLN { get; set; }


    }
}
