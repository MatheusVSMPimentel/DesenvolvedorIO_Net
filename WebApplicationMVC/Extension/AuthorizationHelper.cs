using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebApplicationMVC.Extension
{
    public class PermissaoPolicy : IAuthorizationRequirement
    {
        public string Permissao { get; }

        public PermissaoPolicy(string permissao)
        {
            Permissao = permissao;
        }
    }

    public class PermissaoHandler : AuthorizationHandler<PermissaoPolicy>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PermissaoPolicy requisitos)
        {
            if (context.User.HasClaim(c => c.Type == "Permissao" || c.Type == "PodeVer" && c.Value.Contains(requisitos.Permissao)))
            {
                context.Succeed(requisitos);
            }

            return Task.CompletedTask;
        }
    }
}