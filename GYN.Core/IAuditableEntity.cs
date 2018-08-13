using GYN.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYN.Core.Interfaces
{
    public interface IAuditableEntity
    {

        DateTime CreatedDate { get; set; }

        ApplicationUser CreatedBy { get; set; }

        DateTime UpdatedDate { get; set; }

        ApplicationUser UpdatedBy { get; set; }
    }
}
