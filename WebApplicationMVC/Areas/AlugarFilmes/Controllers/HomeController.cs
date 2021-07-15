using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationMVC.Areas.AlugarFilmes.Controllers
{
    [Area("AlugarFilmes")]
    public class Home : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}