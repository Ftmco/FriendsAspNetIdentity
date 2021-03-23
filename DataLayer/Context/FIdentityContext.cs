//Friends Tm Co Identity Package 
//You can see or develop this package in https://github.com/ftmco or https://friendstmco.ir/fidentity

using FTeam.Identity.Entity.Roles;
using FTeam.Identity.Entity.Sessions;
using FTeam.Identity.Entity.Users;
using Microsoft.EntityFrameworkCore;

namespace FTeam.Identity.DataLayer.Context
{

    /// <summary>
    /// Friends Identity Data Base Context
    /// </summary>
    public class FIdentityContext : DbContext 
    {
        /// <summary>
        /// Friends Identity Data Base Context
        /// </summary>
        /// <param name="options">DbContext Option</param>
        public FIdentityContext(DbContextOptions<FIdentityContext> options):base(options)
        {

        }

        /// <summary>
        /// Users Entity
        /// </summary>
        public DbSet<Users> Users { get; set; }

        /// <summary>
        /// Roles Entity
        /// </summary>
        public DbSet<Roles> Roles { get; set; }

        /// <summary>
        /// Users Sessions Entity
        /// </summary>
        public DbSet<UserSessions> UserSessions { get; set; }

        /// <summary>
        /// Users Roles Entity
        /// </summary>
        public DbSet<UsersRoles> UsersRoles { get; set; }
    }
}
