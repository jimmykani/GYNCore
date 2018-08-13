using GYN.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public partial class Site : Entity<int>
    {
        public Site()
        {

            this.Pathologys = new HashSet<Pathology>();

        }
        [MaxLength(200)]
        public string Description { get; set; }

        public int Region { get; set; }
        public int Echelon { get; set; }
        public virtual ICollection<Pathology> Pathologys { get; set; }
        public virtual ICollection<Radiology> Radiologys { get; set; }
    }
}
