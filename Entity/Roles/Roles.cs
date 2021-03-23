//Friends Tm Co Identity Package 
//You can see or develop this package in https://github.com/ftmco or https://friendstmco.ir/fidentity

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FTeam.Identity.Entity.Roles
{

    /// <summary>
    /// Friends Identity Roles Entity
    /// </summary>
    public record Roles
    {
        public Roles()
        {

        }

        /// <summary>
        /// Role Primary Key
        /// </summary>
        [Key]
        public Guid RoleId { get; set; }

        /// <summary>
        /// Role Title
        /// </summary>
        [Display(Name = "Role Title")]
        [Required]
        public string RoleTitle { get; set; }

        /// <summary>
        /// Role Name
        /// </summary>
        [Display(Name = "Role Name")]
        [Required]
        public string RoleName { get; set; }

        //Navigation Properties

        /// <summary>
        /// Users Roles Relationships
        /// </summary>
        public virtual ICollection<UsersRoles> UsersRoles { get; set; }
    }
}
