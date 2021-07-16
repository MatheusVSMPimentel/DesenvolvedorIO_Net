using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Data;

namespace WebApplicationMVC.Areas.AlugarFilmes.Controllers
{
    [Area("AlugarFilmes")]
    public class Home : Controller
    {
        private readonly IPedidosRepository _pedidosRepository;

        public Home(IPedidosRepository pedidosRepository)
        {
            _pedidosRepository = pedidosRepository;
        }
        public IActionResult Index()
        {
            var pedido = _pedidosRepository.ObterPedido();
            return View(pedido);
        }
    }
}