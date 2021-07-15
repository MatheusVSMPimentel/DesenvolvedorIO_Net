using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Areas.GestaoFilmes.Controllers
{
    [Area("GestaoFilmes")]
    [Route("sysadm")]
    public class AdicionarController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}