using Microsoft.AspNetCore.Builder;
using System;

//Developed By FTeamCo 
//https://github.com/ftmco
//https://friendstmco.ir

namespace FTeam.Identity.Middleware.Tool
{
    /// <summary>
    /// Friends Identity Tool Middleware 
    /// For More Detail Can See 
    /// https://github.com/ftmco
    /// https://friendstmco.ir
    /// </summary>
    public static class FidentityTool
    {
        public static IApplicationBuilder UseFidentity(this IApplicationBuilder applicationBuilder)
        {
            if (applicationBuilder == null)
            {
                throw new ArgumentNullException(nameof(applicationBuilder));
            }

            return applicationBuilder.UseMiddleware<FIdentityMiddleware>();
        }
    }
}
