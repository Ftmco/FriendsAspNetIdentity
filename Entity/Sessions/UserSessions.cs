//Friends Tm Co Identity Package 
//You can see or develop this package in https://github.com/ftmco or https://friendstmco.ir/fidentity

using System;
using System.ComponentModel.DataAnnotations;

namespace FTeam.Identity.Entity.Sessions
{

    /// <summary>
    /// Friends Identity Users Sessions Entity
    /// </summary>
    public record UserSessions
    {
        public UserSessions()
        {

        }

        /// <summary>
        /// Sessions Primary Key
        /// </summary>
        [Key]
        public Guid SessionId { get; set; }

        /// <summary>
        /// Session
        /// </summary>
        [Required]
        public string Session { get; set; }

        /// <summary>
        /// Session Set Date 
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Session Expire Date
        /// </summary>
        [Required]
        public DateTime ExpireDate { get; set; }

        //Navigation Properties

        /// <summary>
        /// User Id Forgen Key
        /// </summary>
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// Users Relationships
        /// </summary>
        public virtual Users.Users Users { get; set; }
    }
}
