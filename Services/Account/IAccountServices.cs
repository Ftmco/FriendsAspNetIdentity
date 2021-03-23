using FTeam.Identity.PackageViewModels.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTeam.Identity.Services.Account
{
    public interface IAccountServices
    {
        Task<SignUpResponse> SingUp();
    }
}
