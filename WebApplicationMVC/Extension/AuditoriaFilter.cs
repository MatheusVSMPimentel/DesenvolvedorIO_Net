using System;
using System.Collections.Generic;
using System.Linq;
using KissLog;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http.Extensions;

namespace WebApplicationMVC.Extension
{
    public class AuditoriaFilter : IActionFilter
    {
        private ILogger _logger;
        public AuditoriaFilter(ILogger logger)
        {
            _logger = logger;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {         
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                var message = context.HttpContext.User.Identity.Name + "Acessou" +
                    context.HttpContext.Request.GetDisplayUrl();

                _logger.Info(message);
            }
        }
    }
}
