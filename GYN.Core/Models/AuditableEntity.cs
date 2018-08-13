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
    public abstract class AuditableEntity<T> : Entity<T>, IAuditableEntity
    {
        public DateTime CreatedDate { get; set; }

        public int? CreatedById { get; set; }
        public int? UpdatedById { get; set; }
        public DateTime UpdatedDate { get; set; }
        [ForeignKey("CreatedById")]
        public ApplicationUser CreatedBy { get; set; }
        [ForeignKey("UpdatedById")]
        public ApplicationUser UpdatedBy { get; set; }
    }
}
