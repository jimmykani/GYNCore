using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public partial class PathologySite : BaseEntity
    {
        public int PathologyId { get; set; }
        public int SiteId { get; set; }

        public virtual ICollection<Site> Sites { get; set; }
        public virtual Pathology Pathology { get; set; }
     
    }
}
