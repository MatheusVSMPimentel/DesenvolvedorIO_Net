using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace WebApplicationMVC
{
    public class MeuMiddleware
    {
        private readonly RequestDelegate _next;

        public MeuMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            Console.WriteLine("---------------------------Antes---------------------------");
            await _next(httpContext);
            Console.WriteLine("---------------------------Depois---------------------------");
        }
    }

    public  static class MeuMiddleWareExtension
    {
        public static IApplicationBuilder useMeuMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MeuMiddleware>();
        }
    }
}