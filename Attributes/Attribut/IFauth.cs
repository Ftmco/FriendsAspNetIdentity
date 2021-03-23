using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FTeam.Identity.Attributes
{
    /// <summary>
    /// Authurize attribute interface
    /// </summary>
    public interface IFauth
    {
        /// <summary>
        /// When Action Executing
        /// </summary>
        /// <param name="httpContent">Http Context</param>
        Task<HttpContext> OnActionExecutingAsync(HttpContext httpContent);

    }
}
