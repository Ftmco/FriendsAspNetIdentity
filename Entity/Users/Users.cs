//Friends Tm Co Identity Package 
//You can see or develop this package in https://github.com/ftmco or https://friendstmco.ir/fidentity

using FTeam.Identity.Entity.Sessions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FTeam.Identity.Entity.Users
{
    /// <summary>
    /// Friends Identity Package 
    /// Users Entity
    /// </summary>
    public record  Users
    {
        public Users()
        {

        }

        /// <summary>
        /// Users Primary Key
        /// </summary>
        [Key]
        public Guid UserId { get; set; }

        /// <summary>
        /// User Name 
        /// </summary>
        [Display(Name = "User Name")]
        [Required]
        public string UserName { get; set; }
              
        /// <summary>
        /// User email
        /// </summary>
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// User Full Name
        /// </summary>
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        /// <summary>
        /// User Is Active?
        /// </summary>
        [Required]
        public bool IsConfirm { get; set; }

        /// <summary>
        /// User Active Code 
        /// </summary>
        [Required]
        public string ActiveCode { get; set; }

        /// <summary>
        /// User Hash Password
        /// </summary>
        [Display(Name = "Password")]
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Active Date
        /// </summary>
        [Required]
        public DateTime Date { get; set; }

        //Navigation Properties 

        /// <summary>
        /// Users Sessions Relationships
        /// </summary>
        public virtual ICollection<UserSessions> UserSessions { get; set; }

    }
}
