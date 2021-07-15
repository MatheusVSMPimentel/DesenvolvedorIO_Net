using System;

namespace WebApplicationMVC.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Pedido()
        {
            Id = new Guid();
        }
    }
}