//Friends Tm Co Identity Package 
//You can see or develop this package in https://github.com/ftmco or https://friendstmco.ir/fidentity

using System;
using System.ComponentModel.DataAnnotations;

namespace FTeam.Identity.Entity.Roles
{
    /// <summary>
    /// Friends Identity Users Roles Entity 
    /// </summary>
    public record UsersRoles
    {
        public UsersRoles()
        {

        }

        /// <summary>
        /// Users Roles Primary Key
        /// </summary>
        [Key]
        public int UsersRolesId { get; set; }

        //Navigation Properties 

        /// <summary>
        /// Role Id Forgen Key 
        /// </summary>
        [Required]
        public Guid RoleId { get; set; }

        /// <summary>
        /// User Id Forgen Key
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        //Relationships 

        /// <summary>
        /// Users Relationships
        /// </summary>
        public virtual Users.Users Users { get; set; }

        /// <summary>
        /// Roles Relationships
        /// </summary>
        public virtual Roles Roles { get; set; }
    }
}
