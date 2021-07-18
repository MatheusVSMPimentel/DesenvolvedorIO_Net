using Microsoft.AspNetCore.Mvc;
using KissLog;


namespace WebApplicationMVC.Controllers
{
    public class TesteController : Controller
    {
        private readonly ILogger _logger;
        public TesteController(ILogger logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            _logger.Trace("Aconteceu um erro");
            return View();
        }
    }
}
