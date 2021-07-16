using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }

        public IActionResult Index()
        {
            Filme filme = new Filme
            {
                Avaliacao = 10, Custo = 100000000000000000, Genero = "4asdfe", Titulo = "Green Day",
                DataLancamento = DateTime.Now, Oscar = true
            };
            //return RedirectToAction("Privacys", filme);
            return View();
        }

        [Authorize(Roles = "Adm")]
        public IActionResult Privacys(Filme filme)
        {
            if (ModelState.IsValid)
            {
                Console.Write("IsValid");
            }

            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            return View("Privacy");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}