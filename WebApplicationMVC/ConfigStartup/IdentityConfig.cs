using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationMVC.Areas.Identity.Data;
using WebApplicationMVC.Extension;

namespace WebApplicationMVC.ConfigStartup
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentity(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>() //options => options.SignIn.RequireConfirmedAccount = true
                .AddDefaultUI()
                .AddEntityFrameworkStores<LoginGestaoDbContext>();
            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeVer", policy => policy.Requirements.Add(new PermissaoPolicy("PodeVer")));

                //options.AddPolicy("PodeVer", policy => policy.RequireClaim("PodeVer"));
                options.AddPolicy("PodeAlugar", policy => policy.Requirements.Add(new PermissaoPolicy("PodeAlugar")));
                options.AddPolicy("PodeComprar", policy => policy.Requirements.Add(new PermissaoPolicy("PodeComprar")));
            });
            services.AddSingleton<IAuthorizationHandler, PermissaoHandler>();

            return services;
        }
        
    }
}