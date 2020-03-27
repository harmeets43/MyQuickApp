using System;
using System.Collections.Generic;
using DataAccessLayer.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DataAccessLayer.Models {
    public class AppUser : IdentityUser, IBaseEntity
    {
        public virtual string FriendlyName
        {
            get
            {
                string friendlyName = string.IsNullOrWhiteSpace(FullName) ? UserName : FullName;

                if (!string.IsNullOrWhiteSpace(JobTitle))
                    friendlyName = $"{JobTitle} {friendlyName}";

                return friendlyName;
            }
        }

        public string JobTitle { get; set; }
        public string FullName { get; set; }
        public string Configuration { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsLockedOut => this.LockoutEnabled && this.LockoutEnd >= DateTimeOffset.UtcNow;

        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }
        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
