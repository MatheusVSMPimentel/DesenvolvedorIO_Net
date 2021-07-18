using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationMVC.ConfigStartup
{
    public static class AreaPastaConfig
    {
        public static IServiceCollection AddAreas(this IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("Modulos/{2}/View/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Modulos/{2}/View/Shared/{0}.cshtml");
                options.AreaViewLocationFormats.Add("View/Shared/{0}.cshtml");
            });
            return services;
        }
    }
}