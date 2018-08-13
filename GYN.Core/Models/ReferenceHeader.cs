using GYN.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public partial class ReferenceHeader : Entity<int>
    {
        public ReferenceHeader()
        {
            this.ReferenceItems = new HashSet<ReferenceItem>();

        }
        [MaxLength(20)]
        public string Type { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public virtual ICollection<ReferenceItem> ReferenceItems { get; set; }
       // public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
