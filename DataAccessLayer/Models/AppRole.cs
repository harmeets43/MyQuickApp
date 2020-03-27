using DataAccessLayer.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public class AppRole : IdentityRole, IBaseEntity
    {
        public AppRole()
        {

        }

        public AppRole(string roleName) : base(roleName)
        {

        }

        public AppRole(string roleName, string description) : base(roleName)
        {
            Description = description;
        }

        public string Description { get; set; }
        // Base entity properties
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        public virtual ICollection<IdentityUserRole<string>> Users { get; set; }
        public virtual ICollection<IdentityRoleClaim<string>> Claims { get; set; }
    }
}
