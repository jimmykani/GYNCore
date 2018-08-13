using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GYN.Core.Models
{
    public class ApplicationUser : IdentityUser<int, CustomUserLogin, CustomUserRole,
    CustomUserClaim>
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            return userIdentity;
        }

        public ApplicationUser()
        {
            DateCreated = DateTime.Now;
            //CreatedBy_ReferenceHeader = new HashSet<ReferenceHeader>();
            //UpdatedBy_ReferenceHeader = new HashSet<ReferenceHeader>();
            //CreatedBy_ReferenceItem = new HashSet<ReferenceItem>();
            //UpdatedBy_ReferenceItem = new HashSet<ReferenceItem>();
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser, int> manager )
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public bool Activated { get; set; }

        //public virtual ICollection<ClinicalExam> CreateClinicalExam { get; set; }
        //public virtual ICollection<ClinicalExam> UpdateClinicalExam { get; set; }



        //public virtual ICollection<Pathology> CreatedPathology { get; set; }
        //public virtual ICollection<Pathology> UpdatedPathology { get; set; }

        //public virtual ICollection<Patient> CreatedPatient { get; set; }
        //public virtual ICollection<Patient> UpdatedPatient { get; set; }

        //public virtual ICollection<PatientDetail> CreatedPatientDetail { get; set; }
        //public virtual ICollection<PatientDetail> UpdatedPatientDetail { get; set; }


        //public virtual ICollection<ReferenceHeader> CreateReferenceHeader { get; set; }
        //public virtual ICollection<ReferenceHeader> UpdatedReferenceHeader { get; set; }

        //public virtual ICollection<ReferenceItem> CreatedReferenceItem { get; set; }
        //public virtual ICollection<ReferenceItem> UpdatedReferenceItem { get; set; }
        //public virtual ICollection<ReferenceItem> UpdatedBy_ReferenceItem { get; set; }

    }
}
