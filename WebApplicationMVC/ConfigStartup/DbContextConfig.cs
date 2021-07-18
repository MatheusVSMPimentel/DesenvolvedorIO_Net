using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationMVC.Areas.Identity.Data;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.ConfigStartup
{
    public static class DbContextConfig
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            
            
            services.AddDbContext<LoginGestaoDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("LoginGestaoConnection")));
            services.AddDbContext<GestaoDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("GestaoDbContext")));

            return services;
        }
    }
}