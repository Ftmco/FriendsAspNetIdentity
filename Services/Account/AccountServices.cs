using FTeam.Identity.DataLayer.Context;
using FTeam.Identity.Entity.Roles;
using FTeam.Identity.Entity.Users;
using FTeam.Identity.PackageViewModels.Responses;
using FTeam.ServicesController;
using System;
using System.Threading.Tasks;

namespace FTeam.Identity.Services.Account
{
    public class AccountServices : IAccountServices
    {
        #region __Dependency__

        /// <summary>
        /// Users Crud Services
        /// </summary>
        private readonly IServiceController<Users, FIdentityContext> _users;

        /// <summary>
        /// Roles Crud Services
        /// </summary>
        private readonly IServiceController<Roles, FIdentityContext> _roles;

        public AccountServices(IServiceController<Users, FIdentityContext> users, IServiceController<Roles, FIdentityContext> roles)
        {
            _users = users;
            _roles = roles;
        }

        #endregion

        public Task<SignUpResponse> SingUp()
        {
            throw new NotImplementedException();
        }
    }
}
