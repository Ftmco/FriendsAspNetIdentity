using FTeam.Identity.Attributes;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

//Developed By FTeamCo 
//https://github.com/ftmco
//https://friendstmco.ir

namespace FTeam.Identity.Middleware
{
    /// <summary>
    /// Friends Identity Middleware
    /// </summary>
    public class FIdentityMiddleware
    {
        /// <summary>
        /// Request Middleware 
        /// </summary>
        private readonly RequestDelegate _next;

        /// <summary>
        /// Friends Identity Attribure
        /// </summary>
        private readonly IFauth _fauth;

        /// <summary>
        /// Friends Identity Constractor 
        /// For Dependency Injection
        /// </summary>
        /// <param name="next">Request Delegate</param>
        public FIdentityMiddleware(RequestDelegate next)
        {
            _next = next;
            _fauth = new Fauth();
        }

        public async Task Invoke(HttpContext context)
        {
            await Task.Run(async () =>
            {
                try
                {
                    context = await _fauth.OnActionExecutingAsync(context);
                    await _next(context);
                }
                catch (Exception)
                {
                    throw;
                }
            });
        }
    }
}
