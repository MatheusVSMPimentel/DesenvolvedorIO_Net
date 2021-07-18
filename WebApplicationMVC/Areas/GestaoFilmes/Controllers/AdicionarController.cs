using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Data;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Areas.GestaoFilmes.Controllers
{
    [Area("GestaoFilmes")]
    [Route("sysadm")]
    public class AdicionarController : Controller
    {
        private GestaoDbContext _context { get; }

        public AdicionarController(GestaoDbContext context)
        {
            _context = context;
        }
        // GET
        [Authorize]
        public IActionResult Index()
        {
            /*var produtora = new Produtora()
            {
                NomeProdutora = "Paramount",
                ValorPatrimonial = (decimal) 10000.00,
                DataFundacao = DateTime.Now,
                NomeFundador = "Robert Richards",
                };
            _context.Produtoras.Add(produtora);
            _context.SaveChanges();

            var produtora1 = _context.Produtoras.Find(1);
            var produtora2 = _context.Produtoras.FirstOrDefault(a => a.NomeProdutora == "Paramount");
            
            var disney = new Produtora()
            {
                NomeProdutora = "Disney",
                ValorPatrimonial = (decimal) 100000000.00,
                DataFundacao = DateTime.Now,
                NomeFundador = "Walt Disney",
            };
            _context.Produtoras.Add(disney); 
            _context.SaveChanges();
            var produtora3 = _context.Produtoras.Where(a => a.ValorPatrimonial > 1);
            produtora.NomeProdutora = "DreamWorks";
            _context.Update(produtora);
            _context.SaveChanges();
            _context.Remove(disney);
            _context.SaveChanges();
            */
            
            return View();
        }
    }
}