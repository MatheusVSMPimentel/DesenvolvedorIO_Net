using KissLog;
using KissLog.AspNetCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.ConfigStartup
{
    public static class DependencyInjections
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            
            services.AddScoped<ILogger>((context) =>
            {
                return Logger.Factory.Get();
            });

            services.AddLogging(logging =>
            {
                logging.AddKissLog();
            });

            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddTransient<IPedidosRepository, PedidosRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}