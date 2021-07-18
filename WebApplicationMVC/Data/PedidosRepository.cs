using WebApplicationMVC.Models;

namespace WebApplicationMVC.Data
{
    public class PedidosRepository : IPedidosRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }
    }

    public interface IPedidosRepository
    {
        Pedido ObterPedido();
    }
}