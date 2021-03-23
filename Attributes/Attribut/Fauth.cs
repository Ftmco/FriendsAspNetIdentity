using Microsoft.AspNetCore.Http;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace FTeam.Identity.Attributes
{
    /// <summary>
    /// Check Current User is Login or have permisseion 
    /// </summary>
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public sealed class Fauth : Attribute, IFauth
    {
        string _roleName = "";

        /// <summary>
        /// Blank Constructor
        /// </summary>
        public Fauth()
        {

        }

        /// <summary>
        /// Friends Identiity Authorize
        /// </summary>
        /// <param name="roleName">Role Name For Check User Permission</param>
        public Fauth(string roleName)
        {
            _roleName = roleName;
        }

        public Task<HttpContext> OnActionExecutingAsync(HttpContext httpContent)
        {
            throw new NotImplementedException();
        }
    }
}
