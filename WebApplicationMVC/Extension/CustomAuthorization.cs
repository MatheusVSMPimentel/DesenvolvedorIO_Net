using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApplicationMVC.Extension
{
    public class CustomAuthorization
    {
        public static bool ValidarClaimUsuario(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity != null && context.User.Identity.IsAuthenticated && context.User.Claims.Any(claim =>
                claim.Type == claimName && claim.Value.Contains(claimValue)); //bool
        }
    }
    public class RequisitoClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        public RequisitoClaimFilter(Claim claim)
        {
            _claim = claim;
        }
        
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!CustomAuthorization.ValidarClaimUsuario(context.HttpContext, _claim.Type, _claim.Value))
            {
                context.Result = new ForbidResult();
            }
        }
    }

    public class ClaimsAuthorizeAtrribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAtrribute(string claimName,string claimValue) : base(typeof(RequisitoClaimFilter))
        {
            Arguments = new object[] {new Claim(claimName, claimValue)};
        }
    }
}