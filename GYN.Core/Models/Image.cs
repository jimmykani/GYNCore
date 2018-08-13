using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public class Image : AuditableEntity<int>
    {
        public Image()
        {

        }
        public byte[] ImageContent { get; set; }
        public int ImageType { get; set; }

        public int? PathologyId { get; set; }
        public int? RadiologyId { get; set; }
        public int? RadiotherapyId { get; set; }
        public int? PatientDetailId { get; set; }

        [ForeignKey("PathologyId")]
        public virtual Pathology Pathologys { get; set; }
        [ForeignKey("RadiologyId")]
        public virtual Radiology Radiologys { get; set; }
        [ForeignKey("RadiotherapyId")]
        public virtual Radiotherapy Radiotherapys { get; set; }

        [ForeignKey("PatientDetailId")]
        public virtual PatientDetail PatientDetails { get; set; }
    }
}
