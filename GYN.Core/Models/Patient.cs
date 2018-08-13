using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public partial class Patient : AuditableEntity<int>
    {
        public Patient()
        {
           // this.PatientId = new PatientDetail();
            //this.ClinicalExamPatientId = new List<ClinicalExam>();
            //this.PathologyPatientId = new List<Pathology>();
        }
        [Index]
        [MaxLength(10)]
        public string URNumber { get; set; }
        [Index]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Index]
        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? OldPatientId { get; set; }
        public bool Active { get; set; }

        public virtual PatientDetail patientDetail { get; set; }
        public virtual ICollection<ClinicalExam> ClinicalExams { get; set; }
        public virtual ICollection<Pathology> Pathologys { get; set; }
        public virtual ICollection<Radiology> Radiologys { get; set; }
        public virtual ICollection<Radiotherapy> Radiotherapys { get; set; }
        public virtual ICollection<LateToxicitiesFollowUp> LateToxicitiesFollowUps { get; set; }
    }
}
